using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Arayuzler
{
    internal interface IDoktor
    {
        DataTable HastaIdIleHastaBilgileriGetir(int hastaId);
        void RandevulariGetir(int doktorId);

        bool RandevuSonucuGir(string sonuc);
    }
}
