using System;

namespace csharp_enum
{
class Program
{
static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cuma);

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");

            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.Sıcak)
                Console.WriteLine("Hadi dışarı çıkalım.");

            else if (sicaklik >= (int)HavaDurumu.Sıcak && sicaklik < (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");

            else
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha serinlemesini bekleyelim.");

        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }

}
