using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Arayuzler
{
    internal interface ISekreter
    {
        void TumRandevulariListele();
        void DoktorlariComboBoxAktar();
        DataTable HastaIdIleHastaGetir(int hastaId);
        void BugununRandevulariniListele();
        DataTable HastaTcIleHastaGetir(string hastaTc);
        int DoktorAdaGoreDoktorIdGetir(string doktorAd);
        bool RandevuOlustur(int hastaId, int doktorId, string bolum, string tarih, string saat, string sonuc);
        void DoktoraGoreRandevulariGetir(string doktorAdi);
    }
}
