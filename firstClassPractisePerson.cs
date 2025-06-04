using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClassPractise
{
    class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad} {Soyad}, \nDoğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }
    internal class Ogrenci : Person
    {
        public string OgrenciNo { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
        }
    }
    internal class Ogretmen : Person
    {
        public int Maas { get; set; }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Maaş: {Maas}");
        }
    }

}