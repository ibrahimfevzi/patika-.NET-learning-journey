using System;

namespace SessizKontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifadeyi girin: ");
            string input = Console.ReadLine();

            string[] kelimeler = input.Split(' ');

            bool sonuc = false;

            foreach (string kelime in kelimeler)
            {
                char[] karakterler = kelime.ToCharArray();

                for (int i = 0; i < karakterler.Length - 1; i++)
                {
                    if (IsSessizHarf(karakterler[i]) && IsSessizHarf(karakterler[i + 1]))
                    {
                        sonuc = true;
                        break;
                    }
                }

                if (sonuc)
                    break;
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }

        static bool IsSessizHarf(char karakter)
        {
            char[] sessizHarfler = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            return Array.IndexOf(sessizHarfler, char.ToLower(karakter)) != -1;
        }
    }
}
