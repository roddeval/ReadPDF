
namespace ReadPDF
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
            this.txtInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformation.Location = new System.Drawing.Point(26, 159);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInformation.Size = new System.Drawing.Size(516, 271);
            this.txtInformation.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.btnProcessFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblPath);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

