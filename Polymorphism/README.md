# Geometrik Þekillerle Alan Hesaplama

Bu proje, farklý geometrik þekillerin (Kare, Dikdörtgen, Dik Üçgen) alanlarýný hesaplamak için tasarlanmýþ bir C# uygulamasýdýr. Bu uygulama, polimorfizm kullanarak her þeklin kendi alan hesaplama yöntemini özelleþtirir.

## Kullanýlan Teknolojiler

- .NET 8.0
- C#

## Proje Yapýsý

- **BaseGeometrikSekil:** Tüm geometrik þekiller için temel bir sýnýf olup, `Genislik` ve `Yukseklik` property'lerini içerir ve `AlanHesapla` metodunu tanýmlar.
- **Kare:** `BaseGeometrikSekil` sýnýfýndan türetilmiþtir. `AlanHesapla` metodu override edilerek, karenin alaný hesaplanýr.
- **Dikdortgen:** `BaseGeometrikSekil` sýnýfýndan türetilmiþtir. `AlanHesapla` metodu override edilerek, dikdörtgenin alaný hesaplanýr.
- **DikUcgen:** `BaseGeometrikSekil` sýnýfýndan türetilmiþtir. `AlanHesapla` metodu override edilerek, dik üçgenin alaný hesaplanýr.

## Nasýl Çalýþtýrýlýr?

1. Projeyi kopyalayýn:
   
2. Visual Studio 2022'de projeyi açýn.

3. Projeyi derleyin ve çalýþtýrýn:
    - `Program.cs` dosyasýnda, `Main` metodu içinde farklý geometrik þekillerin alan hesaplamalarý yapýlmaktadýr.
    - Konsolda, her bir þeklin alan hesaplamasýný ve hangi þeklin alaný olduðunu görebilirsiniz.

4. Çýktý Örneði:
    ```
    Karenin alaný: 25
    Dikdörtgenin alaný: 24
    Dik üçgenin alaný: 6
    ```

## Katkýda Bulunanlar

Bu proje, `Polymorphism` konseptini öðrenmek ve pratik yapmak amacýyla geliþtirilmiþtir. Katkýda bulunmak isteyenler, projeyi fork edip geliþtirdikten sonra pull request gönderebilirler.
-