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
    public partial class DoktorModul : Form, IDoktor
    {
        DatabaseBaglantisi db = new DatabaseBaglantisi();
        private int doktorId;
        private int sonSecilenHastaId = -1;
        private int sonSecilenRandevuId = -1;
        public DoktorModul(int dokId)
        {
            InitializeComponent();
            doktorId = dokId;
            RandevulariGetir(doktorId);
        }

        private void DoktorModul_Load(object sender, EventArgs e)
        {

        }

        public DataTable HastaIdIleHastaBilgileriGetir(int hastaId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Hasta WHERE id={hastaId}";
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

        public bool RandevuSonucuGir(string sonuc)
        {
            bool cevap = false;
            String query = $"UPDATE Randevu SET sonuc = '{sonuc}' WHERE id={sonSecilenRandevuId}";
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

        public void RandevulariGetir(int doktorId)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT Randevu.id as 'randevu_id',Hasta.id as 'hasta_id', Doktor.ad + ' ' + Doktor.soyad as 'doktor_ad', Hasta.ad + ' ' + Hasta.soyad as 'hasta_ad', Hasta.cinsiyet as 'cinsiyet',bolum,FORMAT(tarih,'dd MMMM yyyy', 'tr-TR') as 'tarih',saat,sonuc FROM Randevu" +
                $" INNER JOIN Doktor ON Doktor.id = Randevu.doctorId INNER JOIN Hasta ON Hasta.id = Randevu.hastaId WHERE doctorId = {doktorId}";
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
                    randevuDGV.Columns["randevu_id"].HeaderText = "Randevu ID";
                    randevuDGV.Columns["hasta_id"].HeaderText = "Hasta ID";
                    randevuDGV.Columns["doktor_ad"].HeaderText = "Doktor";
                    randevuDGV.Columns["hasta_ad"].HeaderText = "Hasta";
                    randevuDGV.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                    randevuDGV.Columns["bolum"].HeaderText = "Bölüm";
                    randevuDGV.Columns["tarih"].HeaderText = "Tarih";
                    randevuDGV.Columns["saat"].HeaderText = "Saat";
                    randevuDGV.Columns["sonuc"].HeaderText = "Sonuç";

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

        private void randevuDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = randevuDGV.Rows[e.RowIndex];

                //string tarih = ((DateTime)clickedRow.Cells[2].Value).ToString("yyyy-MM-dd HH:mm:ss");
                int hasta_id = Int16.Parse(clickedRow.Cells[1].Value.ToString());
                String sonuc= clickedRow.Cells[8].Value.ToString();
                randevuSonucRichTextBox.Text = sonuc;
                sonSecilenHastaId = hasta_id;
                sonSecilenRandevuId = Int16.Parse(clickedRow.Cells[0].Value.ToString());
                DataTable ilgiliHasta = HastaIdIleHastaBilgileriGetir(hasta_id);
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

        private void randevuSonucGir_Click(object sender, EventArgs e)
        {
            if (sonSecilenRandevuId != -1)
            {
                bool cevap = RandevuSonucuGir(randevuSonucRichTextBox.Text);
                if (cevap)
                {
                    MessageBox.Show("Muayene sonucu başarıyla eklendi!","Bilgi");
                    RandevulariGetir(doktorId);
                }
                else
                {
                    MessageBox.Show("Muayene sonucu eklenirken hata!","Hata");

                }
            }
            else
            {
                MessageBox.Show("Muayene seçmediniz!","Hata");

            }

        }
    }
}
