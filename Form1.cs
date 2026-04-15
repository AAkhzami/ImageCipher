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
        public frmImageCipher()
        {
            InitializeComponent();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FilePath = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (FilePath.Length > 0)
            {
                MessageBox.Show("File path : " + FilePath[0]);
            }
            else
                MessageBox.Show("There are no path");
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            // to check if the data is in the form of file drop
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
