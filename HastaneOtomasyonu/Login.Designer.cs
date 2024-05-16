namespace HastaneOtomasyonu
{
    partial class Login
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
            this.loginButton = new System.Windows.Forms.Button();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.hastaRadioButton = new System.Windows.Forms.RadioButton();
            this.sekreterRadioButton = new System.Windows.Forms.RadioButton();
            this.doctorRadioButton = new System.Windows.Forms.RadioButton();
            this.sifremiUnuttumLabel = new System.Windows.Forms.Label();
            this.hesapOlusturLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sifreGosterGizle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifreGosterGizle)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(137, 132);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 69);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdiLabel.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(8, 40);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(123, 33);
            this.kullaniciAdiLabel.TabIndex = 1;
            this.kullaniciAdiLabel.Text = "Mail Adresi:";
            // 
            // sifreLabel
            // 
            this.sifreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreLabel.ForeColor = System.Drawing.Color.White;
            this.sifreLabel.Location = new System.Drawing.Point(8, 83);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(123, 33);
            this.sifreLabel.TabIndex = 2;
            this.sifreLabel.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "HASTANE OTOMASYONU";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(137, 40);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(188, 33);
            this.mailTextBox.TabIndex = 4;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreTextBox.Location = new System.Drawing.Point(137, 83);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(188, 33);
            this.sifreTextBox.TabIndex = 5;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // hastaRadioButton
            // 
            this.hastaRadioButton.AutoSize = true;
            this.hastaRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.hastaRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaRadioButton.ForeColor = System.Drawing.Color.White;
            this.hastaRadioButton.Location = new System.Drawing.Point(13, 132);
            this.hastaRadioButton.Name = "hastaRadioButton";
            this.hastaRadioButton.Size = new System.Drawing.Size(67, 25);
            this.hastaRadioButton.TabIndex = 6;
            this.hastaRadioButton.TabStop = true;
            this.hastaRadioButton.Text = "Hasta";
            this.hastaRadioButton.UseVisualStyleBackColor = false;
            this.hastaRadioButton.CheckedChanged += new System.EventHandler(this.hastaRadioButton_CheckedChanged);
            // 
            // sekreterRadioButton
            // 
            this.sekreterRadioButton.AutoSize = true;
            this.sekreterRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekreterRadioButton.ForeColor = System.Drawing.Color.White;
            this.sekreterRadioButton.Location = new System.Drawing.Point(13, 154);
            this.sekreterRadioButton.Name = "sekreterRadioButton";
            this.sekreterRadioButton.Size = new System.Drawing.Size(86, 25);
            this.sekreterRadioButton.TabIndex = 7;
            this.sekreterRadioButton.TabStop = true;
            this.sekreterRadioButton.Text = "Sekreter";
            this.sekreterRadioButton.UseVisualStyleBackColor = true;
            this.sekreterRadioButton.CheckedChanged += new System.EventHandler(this.sekreterRadioButton_CheckedChanged);
            // 
            // doctorRadioButton
            // 
            this.doctorRadioButton.AutoSize = true;
            this.doctorRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorRadioButton.ForeColor = System.Drawing.Color.White;
            this.doctorRadioButton.Location = new System.Drawing.Point(13, 176);
            this.doctorRadioButton.Name = "doctorRadioButton";
            this.doctorRadioButton.Size = new System.Drawing.Size(76, 25);
            this.doctorRadioButton.TabIndex = 8;
            this.doctorRadioButton.TabStop = true;
            this.doctorRadioButton.Text = "Doktor";
            this.doctorRadioButton.UseVisualStyleBackColor = true;
            this.doctorRadioButton.CheckedChanged += new System.EventHandler(this.doctorRadioButton_CheckedChanged);
            // 
            // sifremiUnuttumLabel
            // 
            this.sifremiUnuttumLabel.AutoSize = true;
            this.sifremiUnuttumLabel.ForeColor = System.Drawing.Color.White;
            this.sifremiUnuttumLabel.Location = new System.Drawing.Point(244, 214);
            this.sifremiUnuttumLabel.Name = "sifremiUnuttumLabel";
            this.sifremiUnuttumLabel.Size = new System.Drawing.Size(81, 13);
            this.sifremiUnuttumLabel.TabIndex = 9;
            this.sifremiUnuttumLabel.Text = "Şifremi Unuttum";
            // 
            // hesapOlusturLabel
            // 
            this.hesapOlusturLabel.AutoSize = true;
            this.hesapOlusturLabel.ForeColor = System.Drawing.Color.White;
            this.hesapOlusturLabel.Location = new System.Drawing.Point(10, 215);
            this.hesapOlusturLabel.Name = "hesapOlusturLabel";
            this.hesapOlusturLabel.Size = new System.Drawing.Size(119, 13);
            this.hesapOlusturLabel.TabIndex = 10;
            this.hesapOlusturLabel.Text = "Hesap Oluştur (HASTA)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sifreGosterGizle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hesapOlusturLabel);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.sifremiUnuttumLabel);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.doctorRadioButton);
            this.panel1.Controls.Add(this.kullaniciAdiLabel);
            this.panel1.Controls.Add(this.sekreterRadioButton);
            this.panel1.Controls.Add(this.sifreLabel);
            this.panel1.Controls.Add(this.hastaRadioButton);
            this.panel1.Controls.Add(this.sifreTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 236);
            this.panel1.TabIndex = 11;
            // 
            // sifreGosterGizle
            // 
            this.sifreGosterGizle.BackColor = System.Drawing.Color.White;
            this.sifreGosterGizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifreGosterGizle.Image = global::HastaneOtomasyonu.Properties.Resources.show;
            this.sifreGosterGizle.Location = new System.Drawing.Point(291, 86);
            this.sifreGosterGizle.Name = "sifreGosterGizle";
            this.sifreGosterGizle.Size = new System.Drawing.Size(30, 25);
            this.sifreGosterGizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifreGosterGizle.TabIndex = 29;
            this.sifreGosterGizle.TabStop = false;
            this.sifreGosterGizle.Click += new System.EventHandler(this.sifreGosterGizle_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.loginBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 240);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu - Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifreGosterGizle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.RadioButton hastaRadioButton;
        private System.Windows.Forms.RadioButton sekreterRadioButton;
        private System.Windows.Forms.RadioButton doctorRadioButton;
        private System.Windows.Forms.Label sifremiUnuttumLabel;
        private System.Windows.Forms.Label hesapOlusturLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox sifreGosterGizle;
    }
}