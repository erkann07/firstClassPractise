using firstClassPractise;

namespace firstClassPractise
{
    class Program
    {
        static void Main()
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Ali";
            ogrenci1.Soyad = "Demir";
            ogrenci1.DogumTarihi = new DateTime(2000, 5, 15);
            ogrenci1.OgrenciNo = "148256";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Ad = "Ayşe";
            ogrenci2.Soyad = "Yılmaz";
            ogrenci2.DogumTarihi = new DateTime(2001, 3, 20);
            ogrenci2.OgrenciNo = "148257";

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.Ad = "Mehmet";
            ogrenci3.Soyad = "Kara";
            ogrenci3.DogumTarihi = new DateTime(1999, 8, 10);
            ogrenci3.OgrenciNo = "148258";

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Fatma";
            ogretmen1.Soyad = "Çelik";
            ogretmen1.DogumTarihi = new DateTime(1985, 12, 25);
            ogretmen1.Maas = 35000;

            Ogretmen ogretmen2 = new Ogretmen();
            ogretmen2.Ad = "Ahmet";
            ogretmen2.Soyad = "Koç";
            ogretmen2.DogumTarihi = new DateTime(1980, 6, 30);
            ogretmen2.Maas = 40000;

            Ogretmen ogretmen3 = new Ogretmen();
            ogretmen3.Ad = "Elif";
            ogretmen3.Soyad = "Aydın";
            ogretmen3.DogumTarihi = new DateTime(1990, 1, 5);
            ogretmen3.Maas = 38000;

            List<Ogrenci> ogrenciler = new List<Ogrenci>
               {
                   ogrenci1,
                   ogrenci2,
                   ogrenci3
               };

            Console.WriteLine("-------- ÖĞRENCİLER ---------------");
            foreach (var ogrenci in ogrenciler)
            {
                ogrenci.BilgileriYazdir();
            }
            Console.WriteLine("------- ÖĞRETMENLER ---------------");
            foreach (var ogretmen in new List<Ogretmen> { ogretmen1, ogretmen2, ogretmen3 })
            {
                ogretmen.BilgileriYazdir();
            }
        }
    }
}
