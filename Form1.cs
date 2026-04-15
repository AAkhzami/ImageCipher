using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCipher
{
    public partial class frmImageCipher : Form
    {

        string _FilePath = string.Empty;
        public frmImageCipher()
        {
            InitializeComponent();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FilePath = e.Data.GetData(DataFormats.FileDrop) as string[];
            string extension = System.IO.Path.GetExtension(FilePath[0]).ToLower();
            if (extension != ".jpg" && extension != ".png")
            {
                MessageBox.Show("File type is not supported");
                return;
            }

            if (FilePath.Length > 0)
            {
                MessageBox.Show("File path : " + FilePath[0]);
                _FilePath = FilePath[0];
                lblFilePath.Text = _FilePath;
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            // to check if the data is in the form of file drop

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdChooseImage.Title = "Select Image to Encrypt";
            ofdChooseImage.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
            ofdChooseImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdChooseImage.Multiselect = false;
            ofdChooseImage.CheckFileExists = true;
            ofdChooseImage.RestoreDirectory = true;

            if(ofdChooseImage.ShowDialog() == DialogResult.OK)
            {
                _FilePath = ofdChooseImage.FileName;
                MessageBox.Show("File path : " + _FilePath);
                lblFilePath.Text = _FilePath;

            }

        }
    }
}
