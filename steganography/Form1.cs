using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace steganography
{
    public partial class Form1 : Form
    {
        private string _imagePath;
        private Image _image;
        private Steganogeraphy sg;
        public Form1()
        {
            InitializeComponent();
            sg = new Steganogeraphy();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            // image filters  
            pictureDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" ;
            if (pictureDialog.ShowDialog() != DialogResult.OK) return;
            // image file path  
            _imagePath = lblImageName.Text = pictureDialog.FileName;
            _image = Image.FromFile(_imagePath);

            // display image in picture box  
            pb.Image = _image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pb.Image == null)
            {
                MessageBox.Show("Please Select a picture befor start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbText.Text == "")
            {
                MessageBox.Show("Please Enter a text to embed befor start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Image encryptedImage = sg.EncryptText(_image, tbText.Text);
            pbResult.Image = encryptedImage;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (savePathDialog.ShowDialog() != DialogResult.OK) return;
            string path = savePathDialog.SelectedPath;
            _image.Save(path + "/result.png", ImageFormat.Png);
        }


        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (pbExtract.Image == null)
            {
                MessageBox.Show("Please Select a picture to extract text from that.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Image selectedImage = pbExtract.Image;
            string result = sg.DecryptText(selectedImage);
            tbExtractedText.Text = result;
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            // image filters  
            pictureDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                // image file path  
                _imagePath = lblImageName.Text = pictureDialog.FileName;
                Image image = Image.FromFile(_imagePath);

                // display image in picture box  
                pbExtract.Image = image;

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbExtractedText.Text);
        }

        private void btnShowBits_Click(object sender, EventArgs e)
        {
            if (pb.Image == null)
            {
                MessageBox.Show("Please Select a picture befor start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbText.Text = Steganogeraphy.GetImageBits(pb.Image);
        }
    }

}

