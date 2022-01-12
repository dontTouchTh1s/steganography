using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace steganography
{
    public partial class Form1 : Form
    {
        public string imagePath;
        public Image image;
        public Form1()
        {
            InitializeComponent();

        }


        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            // image filters  
            pictureDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" ;
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                // image file path  
                imagePath = lblImageName.Text = pictureDialog.FileName;
                image = Image.FromFile(imagePath);

                // display image in picture box  
                pb.Image = image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Steganogeraphy sg = new Steganogeraphy();
            Image encryptedImage = sg.encrypt_text(image, tbText.Text);
            pbResult.Image = encryptedImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (savePathDialog.ShowDialog() == DialogResult.OK)
            {
                string path = savePathDialog.SelectedPath;
                ImageFormat f = image.RawFormat;
                image.Save(path + "/result.png", ImageFormat.Png);
            }
        }


        private void btnExtract_Click(object sender, EventArgs e)
        {
            Image selectedImage = pbExtract.Image;
            Steganogeraphy sg = new Steganogeraphy();
            string result = sg.decrypt_text(selectedImage);
            tbExtractedText.Text = result;
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            // image filters  
            pictureDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                // image file path  
                imagePath = lblImageName.Text = pictureDialog.FileName;
                Image image = Image.FromFile(imagePath);

                // display image in picture box  
                pbExtract.Image = image;
            }
        }
    }

}

