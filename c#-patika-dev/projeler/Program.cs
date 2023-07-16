using System;

namespace FibonacciOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisi derinliği: ");
            int derinlik = Convert.ToInt32(Console.ReadLine());

            FibonacciSerisi fibonacci = new FibonacciSerisi();
            int[] serisi = fibonacci.Olustur(derinlik);

            double ortalama = fibonacci.OrtalamaHesapla(serisi);
            Console.WriteLine("Fibonacci serisi ortalaması: " + ortalama);
        }
    }

    class FibonacciSerisi
    {
        public int[] Olustur(int derinlik)
        {
            int[] serisi = new int[derinlik];

            for (int i = 0; i < derinlik; i++)
            {
                if (i < 2)
                    serisi[i] = i;
                else
                    serisi[i] = serisi[i - 1] + serisi[i - 2];
            }

            return serisi;
        }

        public double OrtalamaHesapla(int[] serisi)
        {
            int toplam = 0;
            foreach (int rakam in serisi)
            {
                toplam += rakam;
            }

            double ortalama = (double)toplam / serisi.Length;
            return ortalama;
        }
    }
}
