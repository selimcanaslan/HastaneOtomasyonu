using HastaneOtomasyonu.Arayuzler;
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
        public SekreterModul()
        {
            InitializeComponent();
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
            }

        }
    }
}
