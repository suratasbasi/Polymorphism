# Geometrik �ekillerle Alan Hesaplama

Bu proje, farkl� geometrik �ekillerin (Kare, Dikd�rtgen, Dik ��gen) alanlar�n� hesaplamak i�in tasarlanm�� bir C# uygulamas�d�r. Bu uygulama, polimorfizm kullanarak her �eklin kendi alan hesaplama y�ntemini �zelle�tirir.

## Kullan�lan Teknolojiler

- .NET 8.0
- C#

## Proje Yap�s�

- **BaseGeometrikSekil:** T�m geometrik �ekiller i�in temel bir s�n�f olup, `Genislik` ve `Yukseklik` property'lerini i�erir ve `AlanHesapla` metodunu tan�mlar.
- **Kare:** `BaseGeometrikSekil` s�n�f�ndan t�retilmi�tir. `AlanHesapla` metodu override edilerek, karenin alan� hesaplan�r.
- **Dikdortgen:** `BaseGeometrikSekil` s�n�f�ndan t�retilmi�tir. `AlanHesapla` metodu override edilerek, dikd�rtgenin alan� hesaplan�r.
- **DikUcgen:** `BaseGeometrikSekil` s�n�f�ndan t�retilmi�tir. `AlanHesapla` metodu override edilerek, dik ��genin alan� hesaplan�r.

## Nas�l �al��t�r�l�r?

1. Projeyi kopyalay�n:
   
2. Visual Studio 2022'de projeyi a��n.

3. Projeyi derleyin ve �al��t�r�n:
    - `Program.cs` dosyas�nda, `Main` metodu i�inde farkl� geometrik �ekillerin alan hesaplamalar� yap�lmaktad�r.
    - Konsolda, her bir �eklin alan hesaplamas�n� ve hangi �eklin alan� oldu�unu g�rebilirsiniz.

4. ��kt� �rne�i:
    ```
    Karenin alan�: 25
    Dikd�rtgenin alan�: 24
    Dik ��genin alan�: 6
    ```

## Katk�da Bulunanlar

Bu proje, `Polymorphism` konseptini ��renmek ve pratik yapmak amac�yla geli�tirilmi�tir. Katk�da bulunmak isteyenler, projeyi fork edip geli�tirdikten sonra pull request g�nderebilirler.
-