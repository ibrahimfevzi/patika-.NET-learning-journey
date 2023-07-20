using System;

namespace KelimeIlkSonKarakterYerDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifadeyi girin: ");
            string input = Console.ReadLine();

            string[] kelimeler = input.Split(' ');
            string[] sonuclar = new string[kelimeler.Length];

            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] karakterler = kelimeler[i].ToCharArray();

                if (karakterler.Length > 1)
                {
                    char temp = karakterler[0];
                    karakterler[0] = karakterler[karakterler.Length - 1];
                    karakterler[karakterler.Length - 1] = temp;
                }

                sonuclar[i] = new string(karakterler);
            }

            string sonuc = string.Join(" ", sonuclar);
            Console.WriteLine("Sonuç: " + sonuc);
        }
    }
}
