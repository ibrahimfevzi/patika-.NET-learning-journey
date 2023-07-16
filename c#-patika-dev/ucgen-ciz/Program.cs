using System;

namespace UcgenCizimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin boyutunu girin: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            UcgenCizici ucgenCizici = new UcgenCizici();
            ucgenCizici.UcgenCiz(boyut);
        }
    }

    class UcgenCizici
    {
        public void UcgenCiz(int boyut)
        {
            for (int satir = 1; satir <= boyut; satir++)
            {
                // Boşlukları yazdır
                for (int bosluk = 1; bosluk <= boyut - satir; bosluk++)
                {
                    Console.Write(" ");
                }

                // Yıldızları yazdır
                for (int yildiz = 1; yildiz <= 2 * satir - 1; yildiz++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
