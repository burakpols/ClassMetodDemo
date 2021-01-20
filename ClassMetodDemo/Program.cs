using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Müşteri ekleme
            Musteri musteri1= MusteriManager.MusteriEkle(1, "Burak", "Akay", 24);
            Musteri musteri2 = MusteriManager.MusteriEkle(2, "Mahmut", "Akay", 34);
            Musteri musteri3 = MusteriManager.MusteriEkle(3, "Gizem", "Akay", 15);
            Musteri musteri4 = MusteriManager.MusteriEkle(4, "Lale", "Akay", 21);
            //Müşterileri listeleme
            MusteriManager.MusteriListele(musteri1);
            MusteriManager.MusteriListele(musteri2);
            MusteriManager.MusteriListele(musteri3);
            MusteriManager.MusteriListele(musteri4);



            










        }
    }
}
