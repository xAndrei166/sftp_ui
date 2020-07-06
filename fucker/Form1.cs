using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fucker
{
    

    public partial class Form1 : Form
    {
        private string dataDir = Environment.ExpandEnvironmentVariables(@"%appdata%\SCPUIdata");
        private string dataFile = Environment.ExpandEnvironmentVariables(@"%appdata%\SCPUIdata\auto.txt");



        public Form1()
        {
            InitializeComponent();
            if (File.Exists(dataFile))
            {

                string[] data = File.ReadAllLines(dataFile);
                System.Diagnostics.Trace.WriteLine(dataFile);
                hostPort.Text  = data[0];
                keyPath.Text   = data[1];
                hostName.Text  = data[2];
                outputDir.Text = data[3];

            }

        }

        private string[] runCmd(string c)
        {
            string output = "";
            StreamReader oup;
            StreamReader err;

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = @"cmd.exe";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.WorkingDirectory = @"C:\WINDOWS\System32\";
            startInfo.Arguments = "/C " + c ;

            IntPtr wow64backup = IntPtr.Zero;
            if (!Environment.Is64BitProcess && Environment.Is64BitOperatingSystem)
            {
                NativeMethods.Wow64DisableWow64FsRedirection(ref wow64backup);
            }

            System.Diagnostics.Process P = System.Diagnostics.Process.Start(startInfo);
            oup = P.StandardOutput;
            err = P.StandardError;
            P.WaitForExit();
            output = oup.ReadToEnd();
            output += err.ReadToEnd();

            if (!Environment.Is64BitProcess && Environment.Is64BitOperatingSystem)
            {
                NativeMethods.Wow64RevertWow64FsRedirection(wow64backup);
            }

            return new string[] { P.ExitCode.ToString(), output };
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                sourceFile.Text = file;
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {

            string[] exitInfo = runCmd("scp.exe -P" + hostPort.Text+" -i"+keyPath.Text+" "+sourceFile.Text+" "+hostName.Text+":"+outputDir.Text);
            
            if(exitInfo[0] == "1")
            {
                MessageBox.Show("Unexpected error.\n\noutput: \n"+exitInfo[1], "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(exitInfo[1].Trim() == "")
                MessageBox.Show("File uploaded sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("scp output: \n" + exitInfo[1], "Possible fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            File.WriteAllText (dataFile, hostPort.Text + "\n" );
            File.AppendAllText(dataFile, keyPath.Text + "\n"  );
            File.AppendAllText(dataFile, hostName.Text + "\n" );
            File.AppendAllText(dataFile, outputDir.Text + "\n");

            
        }

        private void keySelect_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog2.FileName;
                keyPath.Text = file;
            }
        }

        internal static class NativeMethods
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);
        }
    }
}
