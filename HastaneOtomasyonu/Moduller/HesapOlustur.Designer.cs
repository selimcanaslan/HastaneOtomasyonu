namespace HastaneOtomasyonu.Moduller
{
    partial class HesapOlustur
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
            this.cinsiyetComboBox = new System.Windows.Forms.ComboBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.iptalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adresRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaKayitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dogTarDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcnoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(122, 135);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(186, 28);
            this.cinsiyetComboBox.TabIndex = 19;
            // 
            // adTextBox
            // 
            this.adTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adTextBox.Location = new System.Drawing.Point(122, 5);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(186, 26);
            this.adTextBox.TabIndex = 8;
            // 
            // iptalButton
            // 
            this.iptalButton.Location = new System.Drawing.Point(122, 299);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(59, 32);
            this.iptalButton.TabIndex = 18;
            this.iptalButton.Text = "İPTAL";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adresRichTextBox
            // 
            this.adresRichTextBox.Location = new System.Drawing.Point(122, 240);
            this.adresRichTextBox.Name = "adresRichTextBox";
            this.adresRichTextBox.Size = new System.Drawing.Size(186, 55);
            this.adresRichTextBox.TabIndex = 17;
            this.adresRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hastaKayitButton
            // 
            this.hastaKayitButton.Location = new System.Drawing.Point(187, 299);
            this.hastaKayitButton.Name = "hastaKayitButton";
            this.hastaKayitButton.Size = new System.Drawing.Size(119, 32);
            this.hastaKayitButton.TabIndex = 16;
            this.hastaKayitButton.Text = "KAYIT OL";
            this.hastaKayitButton.UseVisualStyleBackColor = true;
            this.hastaKayitButton.Click += new System.EventHandler(this.hastaKayitButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dogTarDateTimePicker
            // 
            this.dogTarDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogTarDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogTarDateTimePicker.Location = new System.Drawing.Point(122, 72);
            this.dogTarDateTimePicker.Name = "dogTarDateTimePicker";
            this.dogTarDateTimePicker.Size = new System.Drawing.Size(186, 22);
            this.dogTarDateTimePicker.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "TCNO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(122, 168);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(186, 26);
            this.emailTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcnoTextBox
            // 
            this.tcnoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcnoTextBox.Location = new System.Drawing.Point(122, 103);
            this.tcnoTextBox.Name = "tcnoTextBox";
            this.tcnoTextBox.Size = new System.Drawing.Size(186, 26);
            this.tcnoTextBox.TabIndex = 11;
            this.tcnoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcnoTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadTextBox.Location = new System.Drawing.Point(122, 37);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(186, 26);
            this.soyadTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.sifreTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cinsiyetComboBox);
            this.panel1.Controls.Add(this.adTextBox);
            this.panel1.Controls.Add(this.iptalButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adresRichTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hastaKayitButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dogTarDateTimePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tcnoTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.soyadTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 335);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Şifre:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreTextBox.Location = new System.Drawing.Point(122, 202);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(186, 26);
            this.sifreTextBox.TabIndex = 21;
            // 
            // HesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 335);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HesapOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HesapOlustur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cinsiyetComboBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox adresRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hastaKayitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dogTarDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcnoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label8;
    }
}