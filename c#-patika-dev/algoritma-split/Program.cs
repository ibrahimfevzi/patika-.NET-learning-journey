using System;

namespace StringKarakterCikartma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifadeyi ve indexi (örn: Algoritma,3): ");
            string input = Console.ReadLine();

            string[] inputParts = input.Split(',');
            if (inputParts.Length == 2)
            {
                string ifade = inputParts[0].Trim();
                int index = Convert.ToInt32(inputParts[1].Trim());

                if (index >= 0 && index < ifade.Length)
                {
                    string sonuc = ifade.Remove(index, 1);
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Geçersiz index değeri.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş formatı.");
            }
        }
    }
}
