﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.Moduller
{
    public partial class HesapOlustur : Form
    {
        DatabaseBaglantisi db = new DatabaseBaglantisi();
        public HesapOlustur()
        {
            InitializeComponent();
            cinsiyetComboBox.Items.Insert(0, "Cinsiyet Seçiniz");
            cinsiyetComboBox.SelectedIndex = 0;
            tcnoTextBox.MaxLength = 11;
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private bool KayitOL(string ad, string soyad, string dogTar, string tcNo,
            string cinsiyet, string adres, string mail, string sifre)
        {
            bool cevap = false;
            String query = $"INSERT Hasta VALUES ('{ad}', '{soyad}', '{dogTar}'," +
                $" '{tcNo}', '{cinsiyet}', '{adres}', '{mail}', '{sifre}')";
            db.exception = null;
            db.com.Connection = db.con;
            db.com.CommandText = query;
            try
            {
                int rows_affected = db.com.ExecuteNonQuery();
                if (rows_affected >= 1) { cevap = true; }
                else { cevap = false; }
            }
            catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); }
            return cevap;
        }
        private void hastaKayitButton_Click(object sender, EventArgs e)
        {
            bool cevap = false;
            cevap = KayitOL(adTextBox.Text, soyadTextBox.Text,
                dogTarDateTimePicker.Value.ToString("yyyy-MM-dd"),
                tcnoTextBox.Text, cinsiyetComboBox.Text,
                adresRichTextBox.Text, emailTextBox.Text, sifreTextBox.Text);
            if (cevap) { MessageBox.Show("Hesap Başarıyla Oluşturuldu!"); this.Close(); }
            else
            {
                MessageBox.Show("Hesap Oluşturulamadı!");
            }
        }

        private void tcnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
