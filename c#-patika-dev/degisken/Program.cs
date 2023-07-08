using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            // string ifadeler

            string str1 = string.Empty;
            str1 = "C#";
            string ad = "Ahmet";
            string soyad = "Kara";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            // boolean

            bool bool1 = 10 > 2;

            // Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // 40

            // Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

        }
    }
}