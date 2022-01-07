using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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

        private void Form1_Load(object sender, EventArgs e)
        {

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
            pb.Image = encryptedImage;
            string ttt = sg.decrypt_text((Bitmap)encryptedImage);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (savePathDialog.ShowDialog() == DialogResult.OK)
            {
                string path = savePathDialog.SelectedPath;
                image.Save(path);
            }
        }
    }

}

