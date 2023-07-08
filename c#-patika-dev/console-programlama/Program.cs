using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Soysisminizi giriniz: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Merhaba " + isim + " " + soyisim);
        
        }
    }
}