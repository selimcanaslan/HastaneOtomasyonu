using HastaneOtomasyonu.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HastaneOtomasyonu
{
    public partial class HastaModul : Form, IHasta
    {
        DatabaseBaglantisi db = new DatabaseBaglantisi();
        DataTable tumDoktorlar;
        private DataTable ilkGelenHastaBilgileri;
        private int hastaId;
        public HastaModul(DataTable dt)
        {
            InitializeComponent();
            ilkGelenHastaBilgileri = dt;
            foreach (DataRow dr in dt.Rows)
            {
                adTextBox.Text = dr["ad"].ToString();
                soyadTextBox.Text = dr["soyad"].ToString();
                tcnoTextBox.Text = dr["tckNo"].ToString();
                dogTarDateTimePicker.Text = dr["dogumTarihi"].ToString();
                cinsiyetTextBox.Text = dr["cinsiyet"].ToString();
                adresTextBox.Text = dr["adres"].ToString();
                mailTextBox.Text = dr["email"].ToString();
                sifreTextBox.Text = dr["sifre"].ToString();
                hastaId = Int16.Parse(dr["id"].ToString());
            }
            doktorComboBox.Items.Add("Doktor Seç");
            doktorComboBox.SelectedIndex = 0;
            BolumDoldur();
            SaatDoldur();
            DgvDoldur();
            DoktorlariGetir();
        }

        private void HastaneOtomasyonu_Load(object sender, EventArgs e)
        {
        }

        private void DoktorlariGetir()
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Doktor";
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
            tumDoktorlar = dt;
        }
        // Interface implementations baslangic
        public bool Login(string userName, string password)
        {
            return true;
        }

        public bool BilgiGuncelle(string ad, string soyad, DateTimePicker dogumTarihi, string tcno, string cinsiyet,
            string adres, string mail, string sifre, int id)
        {
            bool cevap = false;
            String query = $"UPDATE Hasta SET ad= '{ad}', soyad='{soyad}', dogumTarihi = '{dogumTarihi.Value.ToString("yyyy-MM-dd HH:mm:ss")}', tckNo='{tcno}'" +
                $", cinsiyet = '{cinsiyet}', adres = '{adres}', email = '{mail}', sifre ='{sifre}' WHERE id = {id}";
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

        public DataTable HastaBilgileriGetir(int hastaId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Hasta WHERE id = {hastaId}";
            db.com.Connection = db.con;
            db.com.CommandText = query;
            db.da.SelectCommand = db.com;
            try
            {
                db.da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Console.WriteLine("Hasta geldi");
                }
                else
                {
                    Console.WriteLine("Hasta gelemedi");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

        public bool RandevuOlustur(int hastaId, int doktorId, string bolum, string tarih,string saat, string sonuc)
        {
            bool cevap = false;
            String query = $"INSERT Randevu (hastaId,doctorId,bolum,tarih,saat,sonuc) VALUES ({hastaId}, {doktorId}, '{bolum}', '{tarih}', '{saat}', '{sonuc}')";
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

        public DataTable HastaIdIleRandavulariGetir(int hastaId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Randevu WHERE hastaId = {hastaId}";
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
            return dt;
        }

        public DataTable DgvIcinRandevulariCek(int hastaId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT Doktor.ad + ' ' + Doktor.soyad as 'doktor_ad',bolum,tarih,saat,sonuc FROM Randevu" +
                $" INNER JOIN Doktor ON Doktor.id = Randevu.doctorId WHERE hastaId = {hastaId}";
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
            return dt;
        }

        public bool RandevuSil(string tarih, int hastaId)
        {
            bool cevap = false;
            String query = $"DELETE FROM Randevu WHERE hastaId = {hastaId} AND tarih = '{tarih}'";
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
        // Interface implementations bitis

        //Buton clickleri baslangic
        private void hastaBilgiGuncelleButon_Click(object sender, EventArgs e)
        {
            if (DegisiklikVarmi())
            {
                try
                {
                    bool guncellendiMi = BilgiGuncelle(adTextBox.Text, soyadTextBox.Text, dogTarDateTimePicker, tcnoTextBox.Text,
                        cinsiyetTextBox.Text,adresTextBox.Text, mailTextBox.Text, sifreTextBox.Text, hastaId);
                    if (guncellendiMi)
                    {
                        MessageBox.Show("Bilgileriniz basariyla guncellendi!", "Bilgi");
                    }
                    else { MessageBox.Show("Bilgiler guncellenirken hata!"); }
                }
                catch (Exception ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); }
            }
            else
            {
                MessageBox.Show("Değişiklik Yapmadınız!", "Bilgi");
            }
        }

        private void randevuOlusturButton_Click(object sender, EventArgs e)
        {
            if (bolumComboBox.Text != "Bölüm Seç" && doktorComboBox.Text != "Doktor Seç")
            {
                if (tarihDateTimePicker.Value > DateTime.Today)
                {
                    if (saatComboBox.Text != "Saat Seç")
                    {
                        int doktorId = -1;
                        foreach (DataRow row in tumDoktorlar.Rows)
                        {
                            if (row["ad"] + " " + row["soyad"] == doktorComboBox.Text)
                            {
                                doktorId = Convert.ToInt16(row["id"].ToString());
                            }
                        }
                        try
                        {
                            bool randevuOlustuMu = RandevuOlustur(hastaId, doktorId, bolumComboBox.Text, tarihDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), saatComboBox.Text, "Henüz Sonuçlanmadı!");
                            if (randevuOlustuMu)
                            {
                                MessageBox.Show("Randevu Başarıyla Oluşturuldu");
                                DgvDoldur();
                            }
                            else
                            {
                                MessageBox.Show("Randevu Oluşturma İşlemi Başarısız");
                            }
                        }
                        catch (SqlException ex) { Console.WriteLine(ex.GetType().Name + " - " + ex.Message); }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Randevu Saati Seçiniz!", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Bugünden daha eski bir tarih seçemezsiniz!", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bölüm ve Doktor Seçiniz!", "Hata");
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
        //Buton clickleri bitis

        

        private void DgvDoldur()
        {
            DataTable randevuVerisi = DgvIcinRandevulariCek(hastaId);
            if (randevuVerisi.Rows.Count > 0)
            {
                randevuDGV.DataSource = randevuVerisi;
                randevuDGV.Columns["doktor_ad"].HeaderText = "Doktor";
                randevuDGV.Columns["bolum"].HeaderText = "Bölüm";
                randevuDGV.Columns["tarih"].HeaderText = "Tarih";
                randevuDGV.Columns["saat"].HeaderText = "Saat";
                randevuDGV.Columns["sonuc"].HeaderText = "Sonuç";
                randevuYokLabel.Visible = false;
            }
            else
            {
                randevuDGV.DataSource = randevuVerisi;
                randevuYokLabel.Visible = true;
            }
        }
        private void BolumDoldur()
        {
            bolumComboBox.Items.Add("Bölüm Seç");
            bolumComboBox.SelectedIndex = 0;

            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Bolumler";
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
                foreach (DataRow dr in dt.Rows)
                {
                    bolumComboBox.Items.Add(dr["bolumAdi"].ToString());
                }
            }
        }

        private void SaatDoldur()
        {
            saatComboBox.Items.Add("Saat Seç");
            saatComboBox.SelectedIndex = 0;
            DatabaseBaglantisi db = new DatabaseBaglantisi();
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM RandevuSaatleri";
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
                foreach (DataRow dr in dt.Rows)
                {
                    saatComboBox.Items.Add(dr["saat"].ToString());
                }
            }
        }

        private void bolumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorComboBox.Items.Clear();
            doktorComboBox.Items.Add("Doktor Seç");
            doktorComboBox.SelectedIndex = 0;
            int index = bolumComboBox.SelectedIndex;
            if (index != 0)
            {
                string bolumAdi = bolumComboBox.Text;
                DataTable dt = new DataTable();
                string query = $"SELECT * FROM Doktor WHERE brans = '{bolumAdi}'";
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
                    foreach (DataRow dr in dt.Rows)
                    {
                        doktorComboBox.Items.Add(dr["ad"].ToString() + " " + dr["soyad"].ToString());
                        doktorComboBox.ValueMember = dr["id"].ToString();
                    }
                    doktorComboBox.SelectedIndex = 0;
                }
            }
        }

        private bool DegisiklikVarmi()
        {
            DataTable guncelBilgiler = new DataTable();
            guncelBilgiler = HastaBilgileriGetir(hastaId);
            if (guncelBilgiler.Rows.Count > 0)
            {
                if (adTextBox.Text == guncelBilgiler.Rows[0]["ad"].ToString() &&
                soyadTextBox.Text == guncelBilgiler.Rows[0]["soyad"].ToString() &&
                dogTarDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss") == ((DateTime) guncelBilgiler.Rows[0]["dogumTarihi"]).ToString("yyyy-MM-dd HH:mm:ss") &&
                tcnoTextBox.Text == guncelBilgiler.Rows[0]["tckNo"].ToString() &&
                cinsiyetTextBox.Text == guncelBilgiler.Rows[0]["cinsiyet"].ToString() &&
                adresTextBox.Text == guncelBilgiler.Rows[0]["adres"].ToString() &&
                mailTextBox.Text == guncelBilgiler.Rows[0]["email"].ToString() &&
                sifreTextBox.Text == guncelBilgiler.Rows[0]["sifre"].ToString()
                )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Hasta Gelmedi");
                return false;
            }
            
        }

        private void randevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Perform the desired action with the clicked row
                DataGridViewRow clickedRow = randevuDGV.Rows[e.RowIndex];

                // Example action: Display cell value in a message box
                string tarih = ((DateTime)clickedRow.Cells[2].Value).ToString("yyyy-MM-dd HH:mm:ss");
                DialogResult result = MessageBox.Show("Seçtiğiniz Randevuyu silmek istediğinize emin misiniz?",
                                              "Onayla",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                // Check the result
                if (result == DialogResult.Yes)
                {
                    bool randevuSilindiMi = RandevuSil(tarih, hastaId);
                    if(randevuSilindiMi)
                    {
                        MessageBox.Show("Randevu Başarıyla İptal Edildi!", "Bilgi");
                        DgvDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Randevu İptal Edilirken Hata Oluştu!","Hata");
                    }
                }

            }
        }
    }
}
