// System ve MathOperations namespace'lerini dahil ediyoruz
using System;
using MathOperations;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hesaplama sınıfından nesne oluşturuluyor
            Hesaplama hesap = new Hesaplama();

            // Metotları test etme
            int toplam = hesap.Topla(10, 20);
            int carpim = hesap.Carp(5, 4);

            // Sonuçları ekrana yazdır
            Console.WriteLine($"Toplama Sonucu: {toplam}");
            Console.WriteLine($"Çarpma Sonucu: {carpim}");

            // Kullanıcıya bilgi verme
            Console.WriteLine("\nİşlemler başarıyla tamamlandı. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}