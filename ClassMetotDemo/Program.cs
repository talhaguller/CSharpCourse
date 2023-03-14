using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Talha";
            musteri1.Soyad = "Güller";
            musteri1.Tc = "235165165611";


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Zeynep";
            musteri2.Soyad = "Güller";
            musteri2.Tc = "16116319465616152";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);


            musteriManager.MusteriBİlgileriListele(musteri1);

            Musteri[] musteris = new Musteri[] { musteri1, musteri2 };
            musteriManager.Lİstele(musteris);

            Console.ReadLine();

        }
    }
}
