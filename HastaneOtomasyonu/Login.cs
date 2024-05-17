using HastaneOtomasyonu.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Login : Form
    {
        private string loginType;
        public Login()
        {
            InitializeComponent();
            mailTextBox.Text = "myaslan333@gmail.com";
            sifreTextBox.Text = "myaslan333";
            hastaRadioButton.Checked = true;
        }

        private void hastaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hastaRadioButton.Checked == true)
            {
                loginType = "hasta";
                if (sekreterRadioButton.Checked == true) { sekreterRadioButton.Checked = false; }
                if (doctorRadioButton.Checked == true) { doctorRadioButton.Checked = false; }
            }
            else
            {
                return;
            }
            Console.WriteLine(loginType);
        }

        private void sekreterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sekreterRadioButton.Checked == true)
            {
                loginType = "sekreter";
                if (hastaRadioButton.Checked == true) { hastaRadioButton.Checked = false; }
                if (doctorRadioButton.Checked == true) { doctorRadioButton.Checked = false; }
            }
            else
            {
                return;
            }
            Console.WriteLine(loginType);
        }

        private void doctorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (doctorRadioButton.Checked == true)
            {
                loginType = "doktor";
                if (sekreterRadioButton.Checked == true) { sekreterRadioButton.Checked = false; }
                if (hastaRadioButton.Checked == true) { hastaRadioButton.Checked = false; }
            }
            else
            {
                return;
            }
            Console.WriteLine(loginType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = mailTextBox.Text;
            string sifre = sifreTextBox.Text;
            if (loginType == "hasta")
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Lütfen Email ve Şifre Bilginizi Giriniz!", "Hata");
                }
                else
                {
                    DatabaseBaglantisi db = new DatabaseBaglantisi();
                    DataTable dt = new DataTable();
                    string query = $"SELECT * FROM Hasta WHERE email='{email}' AND sifre='{sifre}'";
                    db.com.Connection = db.con;
                    db.com.CommandText = query;
                    db.da.SelectCommand = db.com;
                    try
                    {
                        db.da.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["email"].ToString() == email && dt.Rows[0]["sifre"].ToString() == sifre)
                        {
                            HastaModul hastaModul = new HastaModul(dt);
                            hastaModul.Closed += (s, args) => this.Show();
                            this.Hide();
                            hastaModul.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eşleşen Kayıt Bulunamadı!\nEmail ya da şifreniz hatalı!", "HATA");
                    }
                }


            }
            else if (loginType == "sekreter")
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Lütfen Email ve Şifre Bilginizi Giriniz!", "Hata");
                }
                else
                {
                    DatabaseBaglantisi db = new DatabaseBaglantisi();
                    DataTable dt = new DataTable();
                    string query = $"SELECT * FROM Sekreter WHERE email='{email}' AND sifre='{sifre}'";
                    db.com.Connection = db.con;
                    db.com.CommandText = query;
                    db.da.SelectCommand = db.com;
                    try
                    {
                        db.da.Fill(dt);
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["email"].ToString() == email && dt.Rows[0]["sifre"].ToString() == sifre)
                        {
                            SekreterModul sekreterModul = new SekreterModul();
                            sekreterModul.Closed += (s, args) => this.Show();
                            this.Hide();
                            sekreterModul.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eşleşen Kayıt Bulunamadı!\nEmail ya da şifreniz hatalı!", "HATA");
                    }
                }
            }
            else if (loginType == "doktor")
            {

            }
            else
            {
                MessageBox.Show("Lütfen Giriş Tipinizi Seçiniz(Hasta-Sekreter-Doktor)", "Hata");
            }
        }

        private void sifreGosterGizle_Click(object sender, EventArgs e)
        {
            if (sifreTextBox.UseSystemPasswordChar)
            {
                sifreTextBox.UseSystemPasswordChar = false;
                sifreGosterGizle.Image = Properties.Resources.hide;
            }
            else
            {
                sifreTextBox.UseSystemPasswordChar = true;
                sifreGosterGizle.Image = Properties.Resources.show;
            }
        }
    }
}
