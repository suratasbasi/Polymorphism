using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual void AlanHesapla()
        {
            Console.WriteLine("Alan hesabı: " + (Genislik * Yukseklik));
        }
    }

    public class Kare : BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("Karenin alanı: " + (Genislik * Yukseklik));
        }
    }
    public class Dikdortgen : BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("Dikdörtgenin alanı: " + (Genislik * Yukseklik));
        }
    }

    public class DikUcgen : BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            Console.WriteLine("Üçgenin alanı: " + ((Genislik * Yukseklik) / 2));
        }
    }

}
