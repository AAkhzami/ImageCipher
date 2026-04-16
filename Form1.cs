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
using System.Diagnostics;

namespace ImageCipher
{
    public partial class frmImageCipher : Form
    {
        private static void LoggingError(string message)
        {
            string sourceName = "ImageCipher";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
            EventLog.WriteEntry(sourceName, message, EventLogEntryType.Error);
        }
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
                _FilePath = FilePath[0];
                MessageBox.Show("File path : " + _FilePath);
                lblFilePath.Text = "File loaded successfully";
                lblFilePath.ForeColor = Color.Green;

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
        private void btnChooseImage_Click(object sender, EventArgs e)
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
                lblFilePath.Text = "File loaded successfully";
                lblFilePath.ForeColor = Color.Green;
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

        // Derive an 16 byte key from user's input becuse AES here requires 16 byte but the user can input any length of strign as a key,
        // so we will hash the input and take the first 16 bytes of the hash as the key for AES encryption 
        private static byte[] _DerivedKey(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                byte[] finalArray = new byte[16];
                Array.Copy(bytes, finalArray, 16);

                return finalArray;
            }
        }
        private bool _EncryptFile(string inputFile, string outputFile, string key, byte[] iv)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = _DerivedKey(key);
                    aesAlg.IV = iv;

                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                    {
                        fsOutput.Write(iv, 0, iv.Length);
                        fsInput.CopyTo(cryptoStream);
                        return true;
                    }
                }
            }
            catch (CryptographicException ex)
            {
                LoggingError("Cryptographic error: " + ex.Message);
            }
            catch (Exception ex)
            {
                LoggingError("General error: " + ex.Message);
            }
            return false;
        }
        private bool _DecryptFile(string inputFile, string outputFile, string key)
        {
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = _DerivedKey(key);

                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    {
                        // here we read the first 16 bytes of the encrypted file to get the IV that was used during encryption,
                        // because the IV is needed for decryption and it was stored at the beginning of the encrypted file.
                        byte[] iv = new byte[16];
                        fsInput.Read(iv, 0, iv.Length);
                        aesAlg.IV = iv;

                        using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                        using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                        using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                        {
                            fsInput.Seek(iv.Length, SeekOrigin.Begin);
                            fsInput.CopyTo(cryptoStream);
                        }
                        return true;
                    }
                }
            }
            catch (CryptographicException ex)
            {
                LoggingError("Cryptographic error: " + ex.Message);
            }
            catch (Exception ex)
            {
                LoggingError("General error: " + ex.Message);
            }
            return false;
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (string.IsNullOrEmpty(_FilePath) && string.IsNullOrEmpty(_FolderPath))
            {
                MessageBox.Show("Please select a file to encrypt.");
                return;
            }

            byte[] iv;
            using (Aes aesAlg = Aes.Create())
            {
                iv = aesAlg.IV;
            }

            string fileEncryptedPath = _FolderPath + "\\" + Path.GetFileNameWithoutExtension(_FilePath) + "_encrypted" + Path.GetExtension(_FilePath);

            if (_EncryptFile(_FilePath, fileEncryptedPath, txbPassword.Text, iv))
            {
                MessageBox.Show("File encrypted successfully! Saved at : " + fileEncryptedPath);
            }
            else
            {
                MessageBox.Show("An error occurred during encryption.");
            }
        }
        private void txbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbPassword, "This field must not be empty!");
            }
            else
                errorProvider1.SetError(txbPassword, null);
        }
        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            fbdCreateFileLocation.Description = "Please select the folder where you want to save the image.";
            fbdCreateFileLocation.ShowNewFolderButton = true;
            if (fbdCreateFileLocation.ShowDialog() == DialogResult.OK)
            {
                _FolderPath = fbdCreateFileLocation.SelectedPath;
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;

            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if (string.IsNullOrEmpty(_FilePath) && string.IsNullOrEmpty(_FolderPath))
            {
                MessageBox.Show("Please select a file to decrypt.");
                return;
            }

            string fileDecryptedPath = _FolderPath + "\\" + Path.GetFileNameWithoutExtension(_FilePath) + "_decrypted" + Path.GetExtension(_FilePath);

            if (_DecryptFile(_FilePath, fileDecryptedPath, txbPassword.Text))
            {
                MessageBox.Show("File decrypted successfully! Saved at : " + fileDecryptedPath);
            }
            else
            {
                MessageBox.Show("An error occurred during decryption.");
            }
        }
    }
}
