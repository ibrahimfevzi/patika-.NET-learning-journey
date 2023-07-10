using System;

namespace recursive_extension_metotlar
{
    class Program{
        static void Main(string[] args)
        {

            /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            */

            //1.Soru
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int[] sayilar = new int[sayi];
            for(int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Çift sayılar: ");
            foreach(int i in sayilar)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //2.Soru
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());
            int[] sayilar2 = new int[sayi2];
            for(int i = 0; i < sayi2; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayilar2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0} sayısına eşit yada tam bölünen sayılar: ", sayi3);
            foreach(int i in sayilar2)
            {
                if(i % sayi3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //3.Soru
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi4 = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[sayi4];
            for(int i = 0; i < sayi4; i++)
            {
                Console.WriteLine("Lütfen {0}. kelimeyi giriniz: ", i+1);
                kelimeler[i] = Console.ReadLine();
            }
            Console.WriteLine("Girilen kelimeler: ");
            for(int i = kelimeler.Length-1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }

            //4.Soru
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelimeler2 = cumle.Split(" ");
            Console.WriteLine("Cümledeki kelime sayısı: {0}", kelimeler2.Length);
            int harfSayisi = 0;
            foreach(string kelime in kelimeler2)
            {
                harfSayisi += kelime.Length;
            }
            Console.WriteLine("Cümledeki harf sayısı: {0}", harfSayisi);


            // tüm sorular çözüldü.

            



        }


    }
}


   