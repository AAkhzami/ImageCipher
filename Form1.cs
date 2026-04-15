using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCipher
{
    public partial class frmImageCipher : Form
    {

        string _FilePath = string.Empty;
        string _FolderPath = string.Empty;
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
                btnDecrypt.Enabled = true;

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
                btnDecrypt.Enabled = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(txbPassword.PasswordChar == '*')
            {
                txbPassword.PasswordChar = '\0';
                pbVisible.Image = Properties.Resources.invisible;
            }
            else
            {
                txbPassword.PasswordChar = '*';
                pbVisible.Image = Properties.Resources.visible;
            }
        }

        private void EncryptFile(string inputFile, string outputFile, string key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    // Write the IV to the beginning of the file
                    fsOutput.Write(iv, 0, iv.Length);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_FilePath) && string.IsNullOrEmpty(_FilePath))
            {
                MessageBox.Show("Please select a file to encrypt.");
                return;
            }
        }

        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
                errorProvider1.SetError(txbPassword, "This field must not be empty!");
            else
                errorProvider1.SetError(txbPassword, "");
            if(txbPassword.Text.Length < 16)
                errorProvider1.SetError(txbPassword, "The key must be exactly 16 characters long!");
            else
                errorProvider1.SetError(txbPassword, "");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fbdCreateFileLocation.Description = "Please select the folder where you want to save the image.";
            fbdCreateFileLocation.ShowNewFolderButton = true;
            if (fbdCreateFileLocation.ShowDialog() == DialogResult.OK)
            {
                _FolderPath = fbdCreateFileLocation.SelectedPath;
                btnEncrypt.Enabled = true;
            }
        }
    }
}
