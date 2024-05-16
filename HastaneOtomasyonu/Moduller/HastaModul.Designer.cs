namespace HastaneOtomasyonu
{
    partial class HastaModul
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
            this.hastaBilgiGuncelleButon = new System.Windows.Forms.Button();
            this.randevuDGV = new System.Windows.Forms.DataGridView();
            this.randevuYokLabel = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcnoTextBox = new System.Windows.Forms.TextBox();
            this.dogTarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cinsiyetTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.sifreGosterGizle = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.saatComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.doktorComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bolumComboBox = new System.Windows.Forms.ComboBox();
            this.randevuOlusturButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.randevuDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreGosterGizle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastaBilgiGuncelleButon
            // 
            this.hastaBilgiGuncelleButon.Location = new System.Drawing.Point(20, 304);
            this.hastaBilgiGuncelleButon.Name = "hastaBilgiGuncelleButon";
            this.hastaBilgiGuncelleButon.Size = new System.Drawing.Size(339, 34);
            this.hastaBilgiGuncelleButon.TabIndex = 0;
            this.hastaBilgiGuncelleButon.Text = "Bilgilerimi Güncelle";
            this.hastaBilgiGuncelleButon.UseVisualStyleBackColor = true;
            this.hastaBilgiGuncelleButon.Click += new System.EventHandler(this.hastaBilgiGuncelleButon_Click);
            // 
            // randevuDGV
            // 
            this.randevuDGV.AllowUserToAddRows = false;
            this.randevuDGV.AllowUserToDeleteRows = false;
            this.randevuDGV.AllowUserToResizeColumns = false;
            this.randevuDGV.AllowUserToResizeRows = false;
            this.randevuDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.randevuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevuDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.randevuDGV.Location = new System.Drawing.Point(0, 358);
            this.randevuDGV.MultiSelect = false;
            this.randevuDGV.Name = "randevuDGV";
            this.randevuDGV.ReadOnly = true;
            this.randevuDGV.RowHeadersVisible = false;
            this.randevuDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.randevuDGV.ShowEditingIcon = false;
            this.randevuDGV.Size = new System.Drawing.Size(730, 197);
            this.randevuDGV.TabIndex = 1;
            this.randevuDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevuDGV_CellClick);
            // 
            // randevuYokLabel
            // 
            this.randevuYokLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevuYokLabel.Location = new System.Drawing.Point(48, 445);
            this.randevuYokLabel.Name = "randevuYokLabel";
            this.randevuYokLabel.Size = new System.Drawing.Size(596, 29);
            this.randevuYokLabel.TabIndex = 2;
            this.randevuYokLabel.Text = "GELECEK TARİHLİ HEKİM RANDEVUNUZ BULUNMAMAKTADIR!";
            // 
            // adTextBox
            // 
            this.adTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adTextBox.Location = new System.Drawing.Point(137, 19);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(222, 29);
            this.adTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadTextBox.Location = new System.Drawing.Point(137, 54);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(222, 29);
            this.soyadTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "TCNO:";
            // 
            // tcnoTextBox
            // 
            this.tcnoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnoTextBox.Location = new System.Drawing.Point(137, 124);
            this.tcnoTextBox.Name = "tcnoTextBox";
            this.tcnoTextBox.Size = new System.Drawing.Size(222, 29);
            this.tcnoTextBox.TabIndex = 9;
            // 
            // dogTarDateTimePicker
            // 
            this.dogTarDateTimePicker.CustomFormat = "yyyy:MM:dd";
            this.dogTarDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogTarDateTimePicker.Location = new System.Drawing.Point(137, 89);
            this.dogTarDateTimePicker.Name = "dogTarDateTimePicker";
            this.dogTarDateTimePicker.Size = new System.Drawing.Size(222, 29);
            this.dogTarDateTimePicker.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cinsiyet:";
            // 
            // cinsiyetTextBox
            // 
            this.cinsiyetTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinsiyetTextBox.Location = new System.Drawing.Point(137, 159);
            this.cinsiyetTextBox.Name = "cinsiyetTextBox";
            this.cinsiyetTextBox.Size = new System.Drawing.Size(222, 29);
            this.cinsiyetTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresTextBox.Location = new System.Drawing.Point(137, 194);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(222, 29);
            this.adresTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mail:";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(137, 229);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(222, 29);
            this.mailTextBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Şifre:";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreTextBox.Location = new System.Drawing.Point(137, 264);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(222, 29);
            this.sifreTextBox.TabIndex = 26;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // sifreGosterGizle
            // 
            this.sifreGosterGizle.BackColor = System.Drawing.Color.White;
            this.sifreGosterGizle.Image = global::HastaneOtomasyonu.Properties.Resources.show;
            this.sifreGosterGizle.Location = new System.Drawing.Point(328, 268);
            this.sifreGosterGizle.Name = "sifreGosterGizle";
            this.sifreGosterGizle.Size = new System.Drawing.Size(27, 21);
            this.sifreGosterGizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifreGosterGizle.TabIndex = 28;
            this.sifreGosterGizle.TabStop = false;
            this.sifreGosterGizle.Click += new System.EventHandler(this.sifreGosterGizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adTextBox);
            this.groupBox1.Controls.Add(this.sifreGosterGizle);
            this.groupBox1.Controls.Add(this.hastaBilgiGuncelleButon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sifreTextBox);
            this.groupBox1.Controls.Add(this.soyadTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mailTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tcnoTextBox);
            this.groupBox1.Controls.Add(this.adresTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dogTarDateTimePicker);
            this.groupBox1.Controls.Add(this.cinsiyetTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 344);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileriniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.saatComboBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tarihDateTimePicker);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.doktorComboBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bolumComboBox);
            this.groupBox2.Controls.Add(this.randevuOlusturButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(385, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 344);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Oluştur";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(10, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 94);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu İptal Et";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(299, 66);
            this.label14.TabIndex = 0;
            this.label14.Text = "Randevu İptal Etmek İçin İlgili Randevuyu Tablodan Tıklayıp İptal Et Seçeneğini S" +
    "eçebilirsiniz.";
            // 
            // saatComboBox
            // 
            this.saatComboBox.FormattingEnabled = true;
            this.saatComboBox.Location = new System.Drawing.Point(94, 159);
            this.saatComboBox.Name = "saatComboBox";
            this.saatComboBox.Size = new System.Drawing.Size(236, 29);
            this.saatComboBox.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "Saat:";
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.CustomFormat = "yyyy:MM:dd";
            this.tarihDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihDateTimePicker.Location = new System.Drawing.Point(94, 115);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(236, 29);
            this.tarihDateTimePicker.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tarih:";
            // 
            // doktorComboBox
            // 
            this.doktorComboBox.FormattingEnabled = true;
            this.doktorComboBox.Location = new System.Drawing.Point(94, 71);
            this.doktorComboBox.Name = "doktorComboBox";
            this.doktorComboBox.Size = new System.Drawing.Size(236, 29);
            this.doktorComboBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Doktor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Bölüm:";
            // 
            // bolumComboBox
            // 
            this.bolumComboBox.FormattingEnabled = true;
            this.bolumComboBox.Location = new System.Drawing.Point(94, 28);
            this.bolumComboBox.Name = "bolumComboBox";
            this.bolumComboBox.Size = new System.Drawing.Size(236, 29);
            this.bolumComboBox.TabIndex = 2;
            this.bolumComboBox.SelectedIndexChanged += new System.EventHandler(this.bolumComboBox_SelectedIndexChanged);
            // 
            // randevuOlusturButton
            // 
            this.randevuOlusturButton.Location = new System.Drawing.Point(6, 197);
            this.randevuOlusturButton.Name = "randevuOlusturButton";
            this.randevuOlusturButton.Size = new System.Drawing.Size(324, 34);
            this.randevuOlusturButton.TabIndex = 1;
            this.randevuOlusturButton.Text = "Randevu Oluştur";
            this.randevuOlusturButton.UseVisualStyleBackColor = true;
            this.randevuOlusturButton.Click += new System.EventHandler(this.randevuOlusturButton_Click);
            // 
            // HastaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.randevuYokLabel);
            this.Controls.Add(this.randevuDGV);
            this.MaximumSize = new System.Drawing.Size(746, 594);
            this.MinimumSize = new System.Drawing.Size(746, 594);
            this.Name = "HastaModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu - Hasta";
            this.Load += new System.EventHandler(this.HastaneOtomasyonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.randevuDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifreGosterGizle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hastaBilgiGuncelleButon;
        private System.Windows.Forms.DataGridView randevuDGV;
        private System.Windows.Forms.Label randevuYokLabel;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tcnoTextBox;
        private System.Windows.Forms.DateTimePicker dogTarDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cinsiyetTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.PictureBox sifreGosterGizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button randevuOlusturButton;
        private System.Windows.Forms.ComboBox doktorComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bolumComboBox;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox saatComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
    }
}

