﻿using Microsoft.WindowsAPICodePack.Dialogs;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SFTPUI
{


    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private string dataDir = Environment.ExpandEnvironmentVariables(@"%appdata%\SFTPUIdata");
        private string dataFile = Environment.ExpandEnvironmentVariables(@"%appdata%\SFTPUIdata\auto.txt");
        private bool hidden = false;
        private bool showMinimize = true;
        private bool minimize = true;


        public Form1()
        {
            InitializeComponent();
            refreshConfig();
        }

        private void refreshConfig()
        {
            if (File.Exists(dataFile))
            {
                try
                {
                    string[] data = File.ReadAllLines(dataFile);
                    hostName.Text = data[0];
                    keyPath.Text = data[1];
                    outputDir.Text = data[2];

                    unixPath.Checked = data[3] == "Unix";
                    dosPath.Checked = data[3] == "DOS";

                    showMinimize = data[4] == "ShowMinimizeWarning";
                    minimize = data[5] == "Minimize";
                }
                catch (Exception)
                {
                    Debug.WriteLine("Using old config file. Generating new.");
                    saveConfig();
                }
            }
        }

        private void saveConfig()
        {
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            File.WriteAllText(dataFile, hostName.Text + "\n");
            File.AppendAllText(dataFile, keyPath.Text + "\n");
            File.AppendAllText(dataFile, outputDir.Text + "\n");
            File.AppendAllText(dataFile, (unixPath.Checked ? "Unix" : "DOS") + "\n");
            File.AppendAllText(dataFile, (showMinimize ? "ShowMinimizeWarning" : "HideMinimizeWarning") + "\n");
            File.AppendAllText(dataFile, (minimize ? "Minimize" : "Close") + "\n");
        }
        private void changeConfig(int line, string n)
        {
            string[] conf = File.ReadAllLines(dataFile);
            conf[line - 1] = n;
            File.WriteAllLines(dataFile, conf);
        }

        private void sourceSelect_Click(object sender, EventArgs e)
        {
            if (uploadFile.Checked)
            {
                CommonOpenFileDialog fd = new CommonOpenFileDialog();
                CommonFileDialogResult result = fd.ShowDialog();
                if (result == CommonFileDialogResult.Ok)
                {
                    string file = fd.FileName;
                    sourcePath.Text = file;
                }
            }
            else
            {
                CommonOpenFileDialog dd = new CommonOpenFileDialog();
                dd.IsFolderPicker = true;
                CommonFileDialogResult result = dd.ShowDialog();
                if (result == CommonFileDialogResult.Ok)
                {
                    string file = dd.FileName;
                    sourcePath.Text = file;
                }
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            saveConfig();
            string host, username, password, fixedOut = "";
            int port = -1;

            try
            {
                host = hostName.Text.Split('@')[1].Split(':')[0];
                try
                {
                    port = int.Parse(hostName.Text.Split('@')[1].Split(':')[1]);
                }
                catch (Exception)
                {
                    port = 22;
                }
                username = hostName.Text.Split('@')[0];
                password = userPass.Text;
                fixedOut = outputDir.Text.EndsWith("/") ? outputDir.Text : outputDir.Text + "/";

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid argument(s).");
                return;
            }

            bool fail = false;
            var coninf = new ConnectionInfo(host, port, username, new PasswordAuthenticationMethod(username, userPass.Text), new PrivateKeyAuthenticationMethod(username, new PrivateKeyFile(keyPath.Text)));
            using (var client = new SftpClient(coninf))
            {
                try
                {
                    client.Connect();

                    if (uploadFile.Checked)
                    {
                        fixedOut += Path.GetFileName(sourcePath.Text);
                        FileStream fs = File.OpenRead(sourcePath.Text);
                        client.UploadFile(fs, fixedOut);

                    }
                    else
                    {
                        foreach (string file in Directory.EnumerateFiles(sourcePath.Text, "*.*", SearchOption.AllDirectories))
                        {
                            var separator = unixPath.Checked ? '/' : '\\';
                            var revseparator = unixPath.Checked ? '\\' : '/';

                            var formattedpath = fixedOut + (Path.GetFileName(sourcePath.Text) +
                                                "/" + file.ReplaceFirst(sourcePath.Text.EndsWith("\\") ?
                                                sourcePath.Text : sourcePath.Text + "\\", ""));
                            formattedpath = formattedpath.Replace(revseparator, separator);

                            FileStream fs = File.OpenRead(file);
                            var splitpath = new List<string>(formattedpath.Split(separator));
                            splitpath.RemoveAt(splitpath.Count - 1);
                            var dirname = string.Join(separator.ToString(), splitpath.ToArray());
                            Debug.WriteLine(formattedpath);
                            Debug.WriteLine(dirname);

                            for (int i = 1; i < splitpath.Count; i++)
                            {
                                string check = string.Join(separator.ToString(), splitpath.Take(i + 1).ToArray());
                                Debug.WriteLine(check);
                                if (!client.Exists(check)) client.CreateDirectory(check);
                            }
                            client.UploadFile(fs, formattedpath);
                        }

                    }

                    client.Disconnect();
                }
                catch (Exception err)
                {
                    MessageBox.Show("SFTP error: " + err.Message);
                    fail = true;
                }
                finally
                {
                    client.Dispose();
                }

            }
            if (!fail) MessageBox.Show("File upload was successful!");
        }

        private void keySelect_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fd = new CommonOpenFileDialog();
            CommonFileDialogResult result = fd.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                string file = fd.FileName;
                keyPath.Text = file;
            }
        }

        private void upload_MouseHover(object sender, EventArgs e)
        {
            upload.Text = "Lol!";
        }

        private void upload_MouseLeave(object sender, EventArgs e)
        {
            upload.Text = "Upload";
        }

        private void close_Click(object sender, EventArgs e)
        {
            refreshConfig();
            if (!minimize)
            {
                this.Close();
            }
            if (showMinimize)
            {
                MessageBox.Show("App will be minimized to tray. Right click the icon and press 'Exit' to completely close it, or change the 'Minimize' line to 'Close'");
                showMinimize = false;
                changeConfig(5, "HideMinimizeWarning");
            }

            hidden = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: ad2017gd\n\nidea from xandreithefrog or whatever");
        }
        private void moveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void unixPath_CheckedChanged(object sender, EventArgs e)
        {
            if (unixPath.Checked)
            {
                outputDir.Hint = "/path/to/dir";
            }
            else
            {
                outputDir.Hint = @"D:\path\to\dir";
            }
        }

        private void uploadFile_CheckedChanged(object sender, EventArgs e)
        {
            if (uploadFile.Checked)
            {
                label3.Text = "File path";
            }
            else
            {
                label3.Text = "Dir path";
            }
        }


        private void sftpui_icon_MouseClick(object sender, MouseEventArgs e)
        {
            if (hidden && e.Button == MouseButtons.Left)
            {
                this.Show();
                hidden = false;
            }
        }

        private void exit_item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openConf_Click(object sender, EventArgs e)
        {
            Process.Start(dataFile);
        }

        private void open_item_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                this.Show();
                hidden = false;
            }
        }
    }
    public class ExTextBox : TextBox
    {
        string hint;
        public string Hint
        {
            get { return hint; }
            set { hint = value; this.Invalidate(); }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf)
            {
                if (!this.Focused && string.IsNullOrEmpty(this.Text)
                    && !string.IsNullOrEmpty(this.Hint))
                {
                    using (var g = this.CreateGraphics())
                    {
                        TextRenderer.DrawText(g, this.Hint, this.Font,
                            this.ClientRectangle, SystemColors.ControlDarkDark, this.BackColor,
                            TextFormatFlags.Top | TextFormatFlags.Left);
                    }
                }
            }
        }
    }
    public static class StringExtensionMethods
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
