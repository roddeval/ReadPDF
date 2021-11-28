
namespace ReadPDF
{
    partial class frmReadPdf
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnProcessFile = new System.Windows.Forms.Button();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.txtInformation2 = new System.Windows.Forms.TextBox();
            this.chkProcessText = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(51, 27);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(54, 53);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "File";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(83, 23);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(346, 20);
            this.txtPath.TabIndex = 1;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(83, 49);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(217, 20);
            this.txtFile.TabIndex = 4;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(454, 27);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Get Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(454, 57);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "Get File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnProcessFile
            // 
            this.btnProcessFile.Location = new System.Drawing.Point(454, 86);
            this.btnProcessFile.Name = "btnProcessFile";
            this.btnProcessFile.Size = new System.Drawing.Size(75, 23);
            this.btnProcessFile.TabIndex = 6;
            this.btnProcessFile.Text = "Process File";
            this.btnProcessFile.UseVisualStyleBackColor = true;
            this.btnProcessFile.Click += new System.EventHandler(this.btnProcessFile_Click);
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(12, 115);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInformation.Size = new System.Drawing.Size(251, 191);
            this.txtInformation.TabIndex = 7;
            // 
            // txtInformation2
            // 
            this.txtInformation2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformation2.Location = new System.Drawing.Point(291, 117);
            this.txtInformation2.Multiline = true;
            this.txtInformation2.Name = "txtInformation2";
            this.txtInformation2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInformation2.Size = new System.Drawing.Size(251, 187);
            this.txtInformation2.TabIndex = 8;
            // 
            // chkProcessText
            // 
            this.chkProcessText.AutoSize = true;
            this.chkProcessText.Location = new System.Drawing.Point(328, 91);
            this.chkProcessText.Name = "chkProcessText";
            this.chkProcessText.Size = new System.Drawing.Size(88, 17);
            this.chkProcessText.TabIndex = 9;
            this.chkProcessText.Text = "Process Text";
            this.chkProcessText.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 313);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(529, 424);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // frmReadPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chkProcessText);
            this.Controls.Add(this.txtInformation2);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.btnProcessFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblPath);
            this.Name = "frmReadPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnProcessFile;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.TextBox txtInformation2;
        private System.Windows.Forms.CheckBox chkProcessText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

