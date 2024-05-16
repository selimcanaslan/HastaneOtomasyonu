using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.Arayuzler
{
    internal interface IRandevu
    {
        DataTable HastaIdIleRandavulariGetir(int hastaId);
        bool RandevuOlustur(int hastaId, int doktorId, string bolum, string tarih,string saat, string sonuc);
        DataTable DgvIcinRandevulariCek(int hastaId);
        bool RandevuSil(string tarih, int hastaId);
    }
}
