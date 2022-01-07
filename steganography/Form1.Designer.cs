
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.pictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.savePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(283, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(232, 190);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // pictureDialog
            // 
            this.pictureDialog.FileName = "openFileDialog1";
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(12, 42);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(127, 29);
            this.btnSelectPicture.TabIndex = 1;
            this.btnSelectPicture.Text = "Select picture";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 113);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(197, 23);
            this.tbText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write your Text to embed im picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose picture";
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(283, 215);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(10, 15);
            this.lblImageName.TabIndex = 5;
            this.lblImageName.Text = ":";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 242);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(13, 189);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 23);
            this.tbPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(245, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Enter a password flag for extracting (optimal)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 277);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.OpenFileDialog pictureDialog;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog savePathDialog;
    }
}

