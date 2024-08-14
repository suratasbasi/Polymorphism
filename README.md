# Polymorphism
# Geometrik Şekillerle Alan Hesaplama

Bu proje, farklı geometrik şekillerin (Kare, Dikdörtgen, Dik Üçgen) alanlarını hesaplamak için tasarlanmış bir C# uygulamasıdır. Bu uygulama, polimorfizm kullanarak her şeklin kendi alan hesaplama yöntemini özelleştirir.

## Kullanılan Teknolojiler

- .NET 8.0
- C#

## Proje Yapısı

- **BaseGeometrikSekil:** Tüm geometrik şekiller için temel bir sınıf olup, `Genislik` ve `Yukseklik` property'lerini içerir ve `AlanHesapla` metodunu tanımlar.
- **Kare:** `BaseGeometrikSekil` sınıfından türetilmiştir. `AlanHesapla` metodu override edilerek, karenin alanı hesaplanır.
- **Dikdortgen:** `BaseGeometrikSekil` sınıfından türetilmiştir. `AlanHesapla` metodu override edilerek, dikdörtgenin alanı hesaplanır.
- **DikUcgen:** `BaseGeometrikSekil` sınıfından türetilmiştir. `AlanHesapla` metodu override edilerek, dik üçgenin alanı hesaplanır.

## Nasıl Çalıştırılır?

1. Projeyi kopyalayın:
   
2. Visual Studio 2022'de projeyi açın.

3. Projeyi derleyin ve çalıştırın:
    - `Program.cs` dosyasında, `Main` metodu içinde farklı geometrik şekillerin alan hesaplamaları yapılmaktadır.
    - Konsolda, her bir şeklin alan hesaplamasını ve hangi şeklin alanı olduğunu görebilirsiniz.

4. Çıktı Örneği:
    ```
    Karenin alanı: 25
    Dikdörtgenin alanı: 24
    Dik üçgenin alanı: 6
    ```

## Katkıda Bulunanlar

Bu proje, `Polymorphism` konseptini öğrenmek ve pratik yapmak amacıyla geliştirilmiştir. Katkıda bulunmak isteyenler, projeyi fork edip geliştirdikten sonra pull request gönderebilirler.
-
