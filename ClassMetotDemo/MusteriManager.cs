using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi "+musteri.Ad+" "+musteri.Soyad);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" Müşteri Silinmiştir");
        }

        public void MusteriBİlgileriListele(Musteri musteri)
        {
            Console.WriteLine("Müşeteri Adı: "+musteri.Ad);
            Console.WriteLine("Müşeteri Soyadı: " + musteri.Soyad);
            Console.WriteLine("Müşeteri Tc: " + musteri.Tc);

        }

        public void Lİstele(Musteri[] musteris)
        {
            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine("Müşeteri Adı: " + musteri.Ad);
                Console.WriteLine("Müşeteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Müşeteri Tc: " + musteri.Tc);
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
