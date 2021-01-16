using System;

namespace Odev
{
    class Program
    {
        public static object urun1;
        public static Urun urun2;
        public static Urun urun3;

        static void Main(string[] args)
        {
            urun1.urunAdi = "Elbise";
            urun1.urunMarka = "Bershka";
            urun1.urunFiyat = 269;




            Urun[] urunler = new Urun[] { (Urun)urun1, urun2, urun3 };
        }
    }


    class Urun
    {
        public string urunAdi { get; set; }
        public string urunMarka { get; set; }
        
        public int urunFiyat { get; set; }

        public int urunStok { get; set; }

    }

}
