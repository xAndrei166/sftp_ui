namespace fucker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.hostName = new System.Windows.Forms.TextBox();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.sourceFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputDir = new System.Windows.Forms.TextBox();
            this.upload = new System.Windows.Forms.Button();
            this.keyPath = new System.Windows.Forms.TextBox();
            this.keySelect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "File";
            // 
            // fileSelect
            // 
            this.fileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSelect.ForeColor = System.Drawing.Color.Black;
            this.fileSelect.Location = new System.Drawing.Point(269, 136);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(48, 26);
            this.fileSelect.TabIndex = 5;
            this.fileSelect.TabStop = false;
            this.fileSelect.Text = "Select";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hostName
            // 
            this.hostName.BackColor = System.Drawing.Color.DarkGray;
            this.hostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostName.ForeColor = System.Drawing.Color.White;
            this.hostName.Location = new System.Drawing.Point(73, 3);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(189, 26);
            this.hostName.TabIndex = 2;
            this.hostName.TabStop = false;
            this.hostName.Tag = "";
            // 
            // hostPort
            // 
            this.hostPort.BackColor = System.Drawing.Color.DarkGray;
            this.hostPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostPort.ForeColor = System.Drawing.Color.White;
            this.hostPort.Location = new System.Drawing.Point(73, 33);
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(189, 26);
            this.hostPort.TabIndex = 8;
            this.hostPort.TabStop = false;
            // 
            // sourceFile
            // 
            this.sourceFile.BackColor = System.Drawing.Color.DarkGray;
            this.sourceFile.Cursor = System.Windows.Forms.Cursors.No;
            this.sourceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceFile.ForeColor = System.Drawing.Color.White;
            this.sourceFile.Location = new System.Drawing.Point(74, 136);
            this.sourceFile.Name = "sourceFile";
            this.sourceFile.ReadOnly = true;
            this.sourceFile.Size = new System.Drawing.Size(189, 26);
            this.sourceFile.TabIndex = 9;
            this.sourceFile.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remote";
            // 
            // outputDir
            // 
            this.outputDir.BackColor = System.Drawing.Color.DarkGray;
            this.outputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDir.ForeColor = System.Drawing.Color.White;
            this.outputDir.Location = new System.Drawing.Point(74, 168);
            this.outputDir.Name = "outputDir";
            this.outputDir.Size = new System.Drawing.Size(189, 26);
            this.outputDir.TabIndex = 11;
            this.outputDir.TabStop = false;
            // 
            // upload
            // 
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.Black;
            this.upload.Location = new System.Drawing.Point(7, 200);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(116, 35);
            this.upload.TabIndex = 3;
            this.upload.TabStop = false;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // keyPath
            // 
            this.keyPath.BackColor = System.Drawing.Color.DarkGray;
            this.keyPath.Cursor = System.Windows.Forms.Cursors.No;
            this.keyPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyPath.ForeColor = System.Drawing.Color.White;
            this.keyPath.Location = new System.Drawing.Point(73, 63);
            this.keyPath.Name = "keyPath";
            this.keyPath.ReadOnly = true;
            this.keyPath.Size = new System.Drawing.Size(189, 26);
            this.keyPath.TabIndex = 15;
            this.keyPath.TabStop = false;
            // 
            // keySelect
            // 
            this.keySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keySelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySelect.ForeColor = System.Drawing.Color.Black;
            this.keySelect.Location = new System.Drawing.Point(268, 63);
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
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Key";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(319, 241);
            this.Controls.Add(this.keyPath);
            this.Controls.Add(this.keySelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.outputDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceFile);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.fileSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 280);
            this.MinimumSize = new System.Drawing.Size(335, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCPUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox hostName;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.TextBox sourceFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputDir;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox keyPath;
        private System.Windows.Forms.Button keySelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

