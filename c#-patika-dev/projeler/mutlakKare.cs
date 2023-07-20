using System;

namespace SayilarinFarkToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıları girin: ");
            string input = Console.ReadLine();

            string[] sayilar = input.Split(' ');

            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = Convert.ToInt32(sayilar[i]);

                if (sayi < 67)
                {
                    int fark = 67 - sayi;
                    toplam += fark;
                }
                else
                {
                    int fark = sayi - 67;
                    int farkKare = fark * fark;
                    toplam += farkKare;
                }
            }

            Console.WriteLine("Sonuç: " + toplam);
        }
    }
}
