using System;



namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }

            }
                Console.WriteLine("Tek Toplam: " + tekToplam);
                Console.WriteLine("Çift Toplam: " + ciftToplam);

            // Break, Continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

            // İç içe for döngüleri
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Dış döngü " + i);
                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine("iç döngü " + j);
                }
            }

            // 1 ile 1000 arasındaki sayılardan sadece 3'e bölünen sayıları ekrana yazdır.
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //while
            //1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac2 = 1;
            int toplam = 0;
            while (sayac2 <= sayi)
            {
                toplam += sayac2;
                sayac2++;
            }
            Console.WriteLine(toplam / sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console'a yazdır.
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }

             // foreach
            Console.WriteLine("***** Foreach *****");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);

            }





        }
    }
}
