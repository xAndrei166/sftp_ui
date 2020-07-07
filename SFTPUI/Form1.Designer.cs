namespace SFTPUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSelect = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.upload = new System.Windows.Forms.Button();
            this.keyPath = new System.Windows.Forms.TextBox();
            this.keySelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.keyPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userPass = new SFTPUI.ExTextBox();
            this.outputDir = new SFTPUI.ExTextBox();
            this.hostName = new SFTPUI.ExTextBox();
            this.uploadFile = new System.Windows.Forms.RadioButton();
            this.uploadDir = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dosPath = new System.Windows.Forms.RadioButton();
            this.unixPath = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 251);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local file/dir";
            // 
            // fileSelect
            // 
            this.fileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSelect.ForeColor = System.Drawing.Color.Black;
            this.fileSelect.Location = new System.Drawing.Point(313, 249);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(48, 26);
            this.fileSelect.TabIndex = 5;
            this.fileSelect.TabStop = false;
            this.fileSelect.Text = "Select";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.sourceSelect_Click);
            // 
            // sourcePath
            // 
            this.sourcePath.BackColor = System.Drawing.Color.DarkGray;
            this.sourcePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePath.ForeColor = System.Drawing.Color.White;
            this.sourcePath.Location = new System.Drawing.Point(118, 249);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(189, 26);
            this.sourcePath.TabIndex = 9;
            this.sourcePath.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 284);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remote dir";
            // 
            // upload
            // 
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.Black;
            this.upload.Location = new System.Drawing.Point(7, 313);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(116, 35);
            this.upload.TabIndex = 3;
            this.upload.TabStop = false;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            this.upload.MouseLeave += new System.EventHandler(this.upload_MouseLeave);
            this.upload.MouseHover += new System.EventHandler(this.upload_MouseHover);
            // 
            // keyPath
            // 
            this.keyPath.BackColor = System.Drawing.Color.DarkGray;
            this.keyPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyPath.ForeColor = System.Drawing.Color.White;
            this.keyPath.Location = new System.Drawing.Point(117, 103);
            this.keyPath.Name = "keyPath";
            this.keyPath.Size = new System.Drawing.Size(189, 26);
            this.keyPath.TabIndex = 15;
            this.keyPath.TabStop = false;
            // 
            // keySelect
            // 
            this.keySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keySelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySelect.ForeColor = System.Drawing.Color.Black;
            this.keySelect.Location = new System.Drawing.Point(312, 103);
            this.keySelect.Name = "keySelect";
            this.keySelect.Size = new System.Drawing.Size(47, 26);
            this.keySelect.TabIndex = 14;
            this.keySelect.TabStop = false;
            this.keySelect.Text = "Select";
            this.keySelect.UseVisualStyleBackColor = false;
            this.keySelect.Click += new System.EventHandler(this.keySelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 105);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "OpenSSH key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "User passwd";
            // 
            // keyPass
            // 
            this.keyPass.BackColor = System.Drawing.Color.DarkGray;
            this.keyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyPass.ForeColor = System.Drawing.Color.White;
            this.keyPass.Location = new System.Drawing.Point(117, 135);
            this.keyPass.Name = "keyPass";
            this.keyPass.PasswordChar = '*';
            this.keyPass.Size = new System.Drawing.Size(189, 26);
            this.keyPass.TabIndex = 19;
            this.keyPass.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 138);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Key passwd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 23);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(345, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 23);
            this.close.TabIndex = 26;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(7, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 18);
            this.button2.TabIndex = 27;
            this.button2.Text = "SFTPUI";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userPass
            // 
            this.userPass.BackColor = System.Drawing.Color.DarkGray;
            this.userPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPass.ForeColor = System.Drawing.Color.White;
            this.userPass.Hint = "bigpp123";
            this.userPass.Location = new System.Drawing.Point(117, 71);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(189, 26);
            this.userPass.TabIndex = 22;
            this.userPass.TabStop = false;
            // 
            // outputDir
            // 
            this.outputDir.BackColor = System.Drawing.Color.DarkGray;
            this.outputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDir.ForeColor = System.Drawing.Color.White;
            this.outputDir.Hint = "C:\\path\\to\\dir";
            this.outputDir.Location = new System.Drawing.Point(118, 281);
            this.outputDir.Name = "outputDir";
            this.outputDir.Size = new System.Drawing.Size(189, 26);
            this.outputDir.TabIndex = 21;
            this.outputDir.TabStop = false;
            // 
            // hostName
            // 
            this.hostName.BackColor = System.Drawing.Color.DarkGray;
            this.hostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostName.ForeColor = System.Drawing.Color.White;
            this.hostName.Hint = "user@host:port";
            this.hostName.Location = new System.Drawing.Point(117, 42);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(189, 26);
            this.hostName.TabIndex = 20;
            this.hostName.TabStop = false;
            // 
            // uploadFile
            // 
            this.uploadFile.AutoSize = true;
            this.uploadFile.Checked = true;
            this.uploadFile.Location = new System.Drawing.Point(7, 3);
            this.uploadFile.Name = "uploadFile";
            this.uploadFile.Size = new System.Drawing.Size(41, 17);
            this.uploadFile.TabIndex = 28;
            this.uploadFile.TabStop = true;
            this.uploadFile.Text = "File";
            this.uploadFile.UseVisualStyleBackColor = true;
            // 
            // uploadDir
            // 
            this.uploadDir.AutoSize = true;
            this.uploadDir.Location = new System.Drawing.Point(71, 4);
            this.uploadDir.Name = "uploadDir";
            this.uploadDir.Size = new System.Drawing.Size(67, 17);
            this.uploadDir.TabIndex = 29;
            this.uploadDir.TabStop = true;
            this.uploadDir.Text = "Directory";
            this.uploadDir.UseVisualStyleBackColor = true;
            // 
            // dosPath
            // 
            this.dosPath.AutoSize = true;
            this.dosPath.Location = new System.Drawing.Point(71, 3);
            this.dosPath.Name = "dosPath";
            this.dosPath.Size = new System.Drawing.Size(62, 17);
            this.dosPath.TabIndex = 31;
            this.dosPath.TabStop = true;
            this.dosPath.Text = "DOS (\\)";
            this.dosPath.UseVisualStyleBackColor = true;
            // 
            // unixPath
            // 
            this.unixPath.AutoSize = true;
            this.unixPath.Checked = true;
            this.unixPath.Location = new System.Drawing.Point(5, 3);
            this.unixPath.Name = "unixPath";
            this.unixPath.Size = new System.Drawing.Size(60, 17);
            this.unixPath.TabIndex = 30;
            this.unixPath.TabStop = true;
            this.unixPath.Text = "Unix (/)";
            this.unixPath.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uploadFile);
            this.panel1.Controls.Add(this.uploadDir);
            this.panel1.Location = new System.Drawing.Point(118, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 24);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.unixPath);
            this.panel2.Controls.Add(this.dosPath);
            this.panel2.Location = new System.Drawing.Point(118, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 22);
            this.panel2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 183);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Input type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 209);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Remote path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(371, 361);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.outputDir);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.keyPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.keyPath);
            this.Controls.Add(this.keySelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.fileSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFTPUI";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox keyPath;
        private System.Windows.Forms.Button keySelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox keyPass;
        private System.Windows.Forms.Label label2;
        private ExTextBox hostName;
        private ExTextBox outputDir;
        private ExTextBox userPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton uploadFile;
        private System.Windows.Forms.RadioButton uploadDir;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton dosPath;
        private System.Windows.Forms.RadioButton unixPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

