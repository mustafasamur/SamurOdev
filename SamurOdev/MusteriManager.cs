using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamurOdev
{
    class MusteriManager
    {
        public void Ekle(Musteri m)
        {
            Console.WriteLine($"{m.Adi} {m.Soyadi} isimli müşteri eklendi!");
        }

        public void Sil()
        {
            Console.WriteLine("Silme İşlemi Tamamlandı");
        }
        public void Listele()
        {
            Console.WriteLine("Müşteri listesi listelendi");
        }

        public void Guncelle(Musteri m)
        {
            Console.WriteLine($"{m.Adi} {m.Soyadi} müşterisi güncellendi");
        }
    }
}
