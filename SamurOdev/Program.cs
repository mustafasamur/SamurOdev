using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamurOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m = new Musteri { Adi = "Hulusi", Soyadi = "DEMİR", Id = 1 };
            Musteri m2 = new Musteri { Adi = "Mustafa", Soyadi = "SAMUR", Id = 2 };
            Musteri m3 = new Musteri { Adi = "Fatih", Soyadi = "GÜMÜŞ", Id = 3 };

            MusteriManager manager = new MusteriManager();
            manager.Ekle(m);
            manager.Ekle(m2);
            manager.Ekle(m3);
            manager.Listele();
            manager.Guncelle(m2);

            Console.ReadKey();
        }
    }
}
