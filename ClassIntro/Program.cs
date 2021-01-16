using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursunEgitmeni = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.kursunEgitmeni = "Kerem Varış";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.kursunEgitmeni = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;


            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.kursunEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.kursunEgitmeni);
            }

            
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }

        public string kursunEgitmeni { get; set; }

        public int izlenmeOrani { get; set; }


    }
}
