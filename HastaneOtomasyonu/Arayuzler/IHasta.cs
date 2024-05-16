using HastaneOtomasyonu.Arayuzler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.Interfaces
{
    internal interface IHasta : IRandevu
    {
        bool Login(string userName, string password);
        DataTable HastaBilgileriGetir(int hastaId);
        bool BilgiGuncelle(string ad, string soyad, DateTimePicker dogumTarihi, string tcno, string cinsiyet,
            string adres, string mail, string sifre, int hastaId);
    }
}
