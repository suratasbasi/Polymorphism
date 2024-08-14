using Polymorphism;

public class Program
{
    public static void Main()
    {
        BaseGeometrikSekil kare = new Kare{ Genislik = 8, Yukseklik = 8 };
        kare.AlanHesapla();

        BaseGeometrikSekil dikdortgen = new Dikdortgen { Genislik = 10, Yukseklik = 7 };
        dikdortgen.AlanHesapla();

        BaseGeometrikSekil dikUcgen = new DikUcgen { Genislik = 11, Yukseklik = 6 }; ;
        dikUcgen.AlanHesapla();
    }
}