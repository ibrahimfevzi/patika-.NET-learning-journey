using System;

namespace KelimeleriTersCevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifadeyi girin: ");
            string input = Console.ReadLine();

            string[] kelimeler = input.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] karakterler = kelimeler[i].ToCharArray();
                Array.Reverse(karakterler);
                kelimeler[i] = new string(karakterler);
            }

            string sonuc = string.Join(" ", kelimeler);
            Console.WriteLine("Sonuç: " + sonuc);
        }
    }
}
