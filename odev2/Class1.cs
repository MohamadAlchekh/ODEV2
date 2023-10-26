using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, string gUnvan, int gYas, int gMesai)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;
        }


        string ad;

        public string Ad { get => ad; set => ad = value; }


        string adres;
        public string Adres { get => adres; set => adres = value; }


        string unvan;
        public string Unvan { get => unvan; set => unvan = value; }


        int yas;
        public int Yas { get => yas; set => yas = value; }


        int mesai;
        public int Mesai { get => mesai; set => mesai = value; }



        public int ucretHesapla()
        {
            return this.Mesai * 100;
        }
        public void ucretHesapla(int ekUcret)
        {

            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());
        }
    }
}
