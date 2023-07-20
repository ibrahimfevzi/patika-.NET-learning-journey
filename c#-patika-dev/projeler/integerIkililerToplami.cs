using System;

namespace IntegerIkililerinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Integer ikilileri girin: ");
            string input = Console.ReadLine();

            string[] ikililer = input.Split(' ');

            for (int i = 0; i < ikililer.Length; i += 2)
            {
                int sayi1 = Convert.ToInt32(ikililer[i]);
                int sayi2 = Convert.ToInt32(ikililer[i + 1]);

                int toplam = sayi1 + sayi2;

                if (sayi1 != sayi2)
                {
                    Console.Write(toplam + " ");
                }
                else
                {
                    int kare = toplam * toplam;
                    Console.Write(kare + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
