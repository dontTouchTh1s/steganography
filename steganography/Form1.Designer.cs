
namespace steganography
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.savePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblPictureInfo = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExtract = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExtractInfo = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbExtractedText = new System.Windows.Forms.TextBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.pbExtract = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtract)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a picture for embeding text in it.";
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(366, 189);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(10, 15);
            this.lblImageName.TabIndex = 5;
            this.lblImageName.Text = ":";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(10, 419);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(366, 3);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(180, 180);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(9, 225);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(348, 162);
            this.tbText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Write your Text to embed im picture";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(559, 476);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblPictureInfo);
            this.tabPage3.Controls.Add(this.pbResult);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Controls.Add(this.pb);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.tbText);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnStart);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lblImageName);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(551, 448);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "embed";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblPictureInfo
            // 
            this.lblPictureInfo.AutoSize = true;
            this.lblPictureInfo.Location = new System.Drawing.Point(363, 393);
            this.lblPictureInfo.Name = "lblPictureInfo";
            this.lblPictureInfo.Size = new System.Drawing.Size(10, 15);
            this.lblPictureInfo.TabIndex = 11;
            this.lblPictureInfo.Text = ":";
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(366, 207);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(180, 180);
            this.pbResult.TabIndex = 10;
            this.pbResult.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(422, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save result picture";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnExtract);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.lblExtractInfo);
            this.tabPage4.Controls.Add(this.btnCopy);
            this.tabPage4.Controls.Add(this.tbExtractedText);
            this.tabPage4.Controls.Add(this.btnChoosePicture);
            this.tabPage4.Controls.Add(this.pbExtract);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(551, 448);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "extract";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(7, 417);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 7;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Extracted text:";
            // 
            // lblExtractInfo
            // 
            this.lblExtractInfo.AutoSize = true;
            this.lblExtractInfo.Location = new System.Drawing.Point(345, 215);
            this.lblExtractInfo.Name = "lblExtractInfo";
            this.lblExtractInfo.Size = new System.Drawing.Size(0, 15);
            this.lblExtractInfo.TabIndex = 5;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(470, 419);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // tbExtractedText
            // 
            this.tbExtractedText.Location = new System.Drawing.Point(9, 240);
            this.tbExtractedText.Multiline = true;
            this.tbExtractedText.Name = "tbExtractedText";
            this.tbExtractedText.Size = new System.Drawing.Size(536, 171);
            this.tbExtractedText.TabIndex = 3;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(9, 182);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePicture.TabIndex = 2;
            this.btnChoosePicture.Text = "Choose picture";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // pbExtract
            // 
            this.pbExtract.Location = new System.Drawing.Point(345, 6);
            this.pbExtract.Name = "pbExtract";
            this.pbExtract.Size = new System.Drawing.Size(200, 200);
            this.pbExtract.TabIndex = 1;
            this.pbExtract.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select pictuer to extract text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 473);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog savePathDialog;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblPictureInfo;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbExtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExtractInfo;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbExtractedText;
        private System.Windows.Forms.Button btnExtract;
    }
}

