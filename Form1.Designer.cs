namespace ImageCipher
{
    partial class frmImageCipher
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbVisible = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdChooseImage = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.lblFilePath);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(34, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 450);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilePath.Location = new System.Drawing.Point(20, 318);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(378, 23);
            this.lblFilePath.TabIndex = 8;
            this.lblFilePath.Text = "...Path...";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseImage.Location = new System.Drawing.Point(65, 374);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(288, 48);
            this.btnChooseImage.TabIndex = 7;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(130, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drag only one file..\r\nSupport JPG,PIN..";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drop Image Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ImageCipher.Properties.Resources.upload;
            this.pictureBox1.InitialImage = global::ImageCipher.Properties.Resources.upload;
            this.pictureBox1.Location = new System.Drawing.Point(159, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pbVisible);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(475, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDecrypt);
            this.panel4.Controls.Add(this.btnEncrypt);
            this.panel4.Location = new System.Drawing.Point(50, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 100);
            this.panel4.TabIndex = 11;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(261, 26);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(35);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(208, 48);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Crimson;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(35, 26);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(35);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(208, 48);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(50, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 50);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ImageCipher.Properties.Resources.warning;
            this.pictureBox3.Location = new System.Drawing.Point(116, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dont lose this password ";
            // 
            // pbVisible
            // 
            this.pbVisible.Image = global::ImageCipher.Properties.Resources.visible;
            this.pbVisible.Location = new System.Drawing.Point(518, 136);
            this.pbVisible.Name = "pbVisible";
            this.pbVisible.Size = new System.Drawing.Size(36, 36);
            this.pbVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVisible.TabIndex = 8;
            this.pbVisible.TabStop = false;
            this.pbVisible.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(44, 136);
            this.txbPassword.MaxLength = 16;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(468, 37);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encryption";
            // 
            // ofdChooseImage
            // 
            this.ofdChooseImage.FileName = "Choose Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 60);
            this.label6.TabIndex = 13;
            this.label6.Text = "Image Cipher";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmImageCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1094, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImageCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Cipher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbVisible;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.OpenFileDialog ofdChooseImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

