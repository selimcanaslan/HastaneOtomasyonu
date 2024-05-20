using HastaneOtomasyonu.Arayuzler;
using HastaneOtomasyonu.Moduller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class SekreterModul : Form, ISekreter
    {
        DatabaseBaglantisi db = new DatabaseBaglantisi();
        string sonListelenen;
        int sonSecilenHastaId = -1;
        public SekreterModul()
        {
            InitializeComponent();
            tcnoTextBoxForSearch.MaxLength = 11;
            doktorComboBox.Items.Insert(0, "Doktor Seçiniz");
            doktorComboBox.SelectedIndex = 0;
            doktorComboBoxForRandevu.Items.Insert(0, "Doktor Seçiniz");
            doktorComboBoxForRandevu.SelectedIndex = 0;

        }
        private void SekreterModul_Load(object sender, EventArgs e)
        {
            TumRandevulariListele();
            DoktorlariComboBoxAktar();
            BolumDoldur();
            SaatDoldur();
        }
        public bool RandevuOlustur(int hastaId, int doktorId, string bolum, string tarih, string saat, string sonuc)
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

        private void bolumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorComboBoxForRandevu.Items.Clear();
            doktorComboBoxForRandevu.Items.Add("Doktor Seç");
            doktorComboBoxForRandevu.SelectedIndex = 0;
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
                        doktorComboBoxForRandevu.Items.Add(dr["ad"].ToString() + " " + dr["soyad"].ToString());
                        doktorComboBoxForRandevu.ValueMember = dr["id"].ToString();
                    }
                    doktorComboBoxForRandevu.SelectedIndex = 0;
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
        public void BugununRandevulariniListele()
        {
            DataTable dt = new DataTable();
            string query = $"EXEC BugununRandevulari '{DateTime.Today:yyyy-MM-dd}'";
            db.com.Connection = db.con;
            db.com.CommandText = query;
            db.da.SelectCommand = db.com;
            db.da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                randevuYokLabel.Visible = false;
                randevuDGV.DataSource = dt;
                randevuDGV.Columns["hasta_id"].HeaderText = "ID";
                randevuDGV.Columns["doktor_ad"].HeaderText = "Doktor";
                randevuDGV.Columns["hasta_ad"].HeaderText = "Hasta";
                randevuDGV.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                randevuDGV.Columns["bolum"].HeaderText = "Bölüm";
                randevuDGV.Columns["tarih"].HeaderText = "Tarih";
                randevuDGV.Columns["saat"].HeaderText = "Saat";
                randevuDGV.Columns["sonuc"].HeaderText = "Sonuç";

                randevuDGV.Columns["hasta_id"].Width = 35;
                randevuDGV.Columns["saat"].Width = 45;
                randevuDGV.Columns["cinsiyet"].Width = 65;
                randevuDGV.Columns["bolum"].Width = 75;
                randevuDGV.Columns["tarih"].Width = 100;

                sonListelenen = "bugununRandevulari";
            }
            else
            {
                randevuDGV.DataSource = dt;
                sonListelenen = "bugununRandevulari";
                randevuYokLabel.Text = "Bugün Tarihli Randevu Bulunamadı!".ToUpper();
                randevuYokLabel.Visible = true;
            }
        }
        public DataTable HastaIdIleHastaGetir(int hastaId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Hasta WHERE id = {hastaId}";
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

        public DataTable HastaTcIleHastaGetir(string hastaTc)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Hasta WHERE tckNo = {hastaTc}";
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

        public void TumRandevulariListele()
        {
            DataTable dt = new DataTable();
            string query = $"SELECT Hasta.id as 'hasta_id', Doktor.ad + ' ' + Doktor.soyad as 'doktor_ad', Hasta.ad + ' ' + Hasta.soyad as 'hasta_ad', Hasta.cinsiyet as 'cinsiyet',bolum,FORMAT(tarih,'dd MMMM yyyy', 'tr-TR') as 'tarih',saat,sonuc FROM Randevu" +
                $" INNER JOIN Doktor ON Doktor.id = Randevu.doctorId INNER JOIN Hasta ON Hasta.id = Randevu.hastaId";
            db.com.Connection = db.con;
            db.com.CommandText = query;
            db.da.SelectCommand = db.com;
            try
            {
                db.da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    randevuYokLabel.Visible = false;
                    randevuDGV.DataSource = dt;
                    randevuDGV.Columns["hasta_id"].HeaderText = "ID";
                    randevuDGV.Columns["doktor_ad"].HeaderText = "Doktor";
                    randevuDGV.Columns["hasta_ad"].HeaderText = "Hasta";
                    randevuDGV.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                    randevuDGV.Columns["bolum"].HeaderText = "Bölüm";
                    randevuDGV.Columns["tarih"].HeaderText = "Tarih";
                    randevuDGV.Columns["saat"].HeaderText = "Saat";
                    randevuDGV.Columns["sonuc"].HeaderText = "Sonuç";

                    randevuDGV.Columns["hasta_id"].Width = 35;
                    randevuDGV.Columns["saat"].Width = 45;
                    randevuDGV.Columns["cinsiyet"].Width = 65;
                    randevuDGV.Columns["bolum"].Width = 75;
                    randevuDGV.Columns["tarih"].Width = 100;

                    sonListelenen = "tumRandevular";
                }
                else
                {
                    randevuYokLabel.Text = "İLERİ TARİHLİ RANDEVU BULUNAMADI!";
                    randevuYokLabel.Visible = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DoktoraGoreRandevulariGetir(string doktorAdi)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT Hasta.id as 'hasta_id', Doktor.ad + ' ' + Doktor.soyad as 'doktor_ad', Hasta.ad + ' ' + Hasta.soyad as 'hasta_ad', Hasta.cinsiyet as 'cinsiyet',bolum,FORMAT(tarih,'dd MMMM yyyy', 'tr-TR') as 'tarih',saat,sonuc FROM Randevu" +
                $" INNER JOIN Doktor ON Doktor.id = Randevu.doctorId INNER JOIN Hasta ON Hasta.id = Randevu.hastaId WHERE Doktor.ad + ' ' + Doktor.soyad = '{doktorAdi}'";
            db.com.Connection = db.con;
            db.com.CommandText = query;
            db.da.SelectCommand = db.com;
            try
            {
                db.da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    randevuYokLabel.Visible = false;
                    randevuDGV.DataSource = dt;
                    randevuDGV.Columns["hasta_id"].HeaderText = "ID";
                    randevuDGV.Columns["doktor_ad"].HeaderText = "Doktor";
                    randevuDGV.Columns["hasta_ad"].HeaderText = "Hasta";
                    randevuDGV.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                    randevuDGV.Columns["bolum"].HeaderText = "Bölüm";
                    randevuDGV.Columns["tarih"].HeaderText = "Tarih";
                    randevuDGV.Columns["saat"].HeaderText = "Saat";
                    randevuDGV.Columns["sonuc"].HeaderText = "Sonuç";

                    randevuDGV.Columns["hasta_id"].Width = 35;
                    randevuDGV.Columns["saat"].Width = 45;
                    randevuDGV.Columns["cinsiyet"].Width = 65;
                    randevuDGV.Columns["bolum"].Width = 75;
                    randevuDGV.Columns["tarih"].Width = 100;
                }
                else
                {
                    randevuYokLabel.Text = "SEÇİLEN DOKTOR'A AİT RANDEVU BULUNAMADI!";
                    randevuYokLabel.Visible = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public int DoktorAdaGoreDoktorIdGetir(string doktorAd)
        {
            int doktorId = -1;
            DataTable dt = new DataTable();
            string query = $"SELECT id FROM Doktor WHERE ad + ' ' + soyad = '{doktorAd}'";
            db.com.Connection = db.con;
            db.com.CommandText = query;
            db.da.SelectCommand = db.com;
            try
            {
                db.da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        doktorId = Int16.Parse(row["id"].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return doktorId;
        }
        public void DoktorlariComboBoxAktar()
        {
            DataTable dt = new DataTable();
            string query = $"SELECT ad + ' ' + soyad as 'tamad' FROM Doktor";
            db.com.Connection = db.con;
            db.com.CommandText = query;
            db.da.SelectCommand = db.com;
            try
            {
                db.da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        doktorComboBox.Items.Add(row["tamad"].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void randevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = randevuDGV.Rows[e.RowIndex];

                //string tarih = ((DateTime)clickedRow.Cells[2].Value).ToString("yyyy-MM-dd HH:mm:ss");
                int hasta_id = Int16.Parse(clickedRow.Cells[0].Value.ToString());
                sonSecilenHastaId = hasta_id;
                DataTable ilgiliHasta = HastaIdIleHastaGetir(hasta_id);
                foreach (DataRow row in ilgiliHasta.Rows)
                {
                    hastaAdiLabel.Text = row["ad"].ToString() + " " + row["soyad"].ToString();
                    cinsiyetLabel.Text = row["cinsiyet"].ToString();
                    tcnoLabel.Text = row["tckNo"].ToString();
                    dogtarLabel.Text = ((DateTime)row["dogumTarihi"]).ToString("dd MMMM yyyy");
                    mailLabel.Text = row["email"].ToString();
                    adresLabel.Text = row["adres"].ToString();
                }
                MessageBox.Show("Hasta Bilgileri Getirildi!", "Bilgi");
            }
        }

        private void butunRandevularButon_Click(object sender, EventArgs e)
        {
            if (sonListelenen == "tumRandevular")
            {
                MessageBox.Show("Tüm randevular zaten listelenmiş halde!", "Bilgi");
            }
            else
            {
                TumRandevulariListele();
                MessageBox.Show("Tüm randevular listelendi!", "Bilgi");
            }
        }

        private void bugununRandevulariButon_Click(object sender, EventArgs e)
        {
            if (sonListelenen == "bugununRandevulari")
            {
                MessageBox.Show("Bugünün randevuları zaten listelenmiş halde!", "Bilgi");
            }
            else
            {
                BugununRandevulariniListele();
                MessageBox.Show("Bugünün randevuları listelendi!", "Bilgi");

            }

        }

        private void randevuOlusturButton_Click(object sender, EventArgs e)
        {
            int doktorId = DoktorAdaGoreDoktorIdGetir(doktorComboBoxForRandevu.Text);
            if (sonSecilenHastaId == -1)
            {
                MessageBox.Show("Henüz Bir Hasta Araması Yapmadınız!");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = HastaIdIleHastaGetir(sonSecilenHastaId);
                DialogResult dialogResult = new DialogResult();
                foreach (DataRow row in dt.Rows)
                {
                    dialogResult = MessageBox.Show(row["ad"].ToString() + " " + row["soyad"].ToString() + " adlı hasta için işlem yapıyorsunuz!\nDevam etmek istediğinize emin misiniz?","Bilgilendirme",MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (doktorId == -1)
                        {
                            MessageBox.Show("Doktor Bulunamadı!");
                        }
                        else
                        {
                            bool cevap = RandevuOlustur(sonSecilenHastaId, doktorId, bolumComboBox.Text,
                           tarihDateTimePicker.Value.ToString("yyyy-MM-dd"), saatComboBox.Text, "Henüz Sonuçlanmadı");
                            if (cevap)
                            {
                                MessageBox.Show("Randevu Başarıyla Oluşturuldu!");
                                sonListelenen = "";
                                TumRandevulariListele();
                            }
                            else
                            {
                                MessageBox.Show("Randevu Oluşturulurken Hata!");
                            }
                        }    
                    }
                    else
                    {
                        MessageBox.Show("İşleminiz İptal Edildi Doğru Hasta İçin Randevu Oluşturduğunuza Emin Olun!","Bilgilendirme");
                    }
                }           
            }
        }

        private void doktoraGoreAraButon_Click(object sender, EventArgs e)
        {
            if(doktorComboBox.Text != "Doktor Seçiniz")
            {
                string secilenDoktor = doktorComboBox.Text;
                DoktoraGoreRandevulariGetir(secilenDoktor);
                MessageBox.Show("Seçilen Doktorun Randevuları Getirildi!");
                sonListelenen = "";
            }
            else
            {
                MessageBox.Show("Lütfen Doktor Seçiniz!", "Hata");

            }
        }

        private void hastaAra_Click(object sender, EventArgs e)
        {
            string tcNo = tcnoTextBoxForSearch.Text;
            if (!string.IsNullOrEmpty(tcNo))
            {
                if (tcnoTextBoxForSearch.Text.Length < 11)
                {
                    MessageBox.Show("TCNO 11 Haneli Olmalı!");

                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = HastaTcIleHastaGetir(tcNo);
                    foreach (DataRow row in dt.Rows)
                    {
                        sonSecilenHastaId = Int16.Parse(row["id"].ToString());
                        hastaAdiLabel.Text = row["ad"].ToString() + " " + row["soyad"].ToString();
                        cinsiyetLabel.Text = row["cinsiyet"].ToString();
                        tcnoLabel.Text = row["tckNo"].ToString();
                        dogtarLabel.Text = ((DateTime)row["dogumTarihi"]).ToString("dd MMMM yyyy");
                        mailLabel.Text = row["email"].ToString();
                        adresLabel.Text = row["adres"].ToString();
                    }
                    MessageBox.Show("Hasta Bilgileri Başarıyla Getirildi!\nRandevu oluşturmak işlemlerinizi gerçekleştirebilirsiniz!", "Bilgi");

                }
            }
            else
            {
                MessageBox.Show("TCNO Girmediniz!");
            }
        }

        private void hastaKayitButton_Click(object sender, EventArgs e)
        {
            SekreterHastaKayit hastaKayit = new SekreterHastaKayit();
            hastaKayit.ShowDialog();
        }

        private void tcnoTextBoxForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
