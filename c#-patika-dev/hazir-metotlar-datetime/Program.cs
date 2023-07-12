using System;



namespace hazir_metotlar_datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Writeline(DateTime.Now); // 9/24/2021 11:00:00 AM
            Console.Writeline(DateTime.Now.Date); // 9/24/2021 12:00:00 AM
            Console.Writeline(DateTime.Now.Day); // 24
            Console.Writeline(DateTime.Now.Month); // 9
            Console.Writeline(DateTime.Now.Year); // 2021
            Console.Writeline(DateTime.Now.Hour); // 11
            Console.Writeline(DateTime.Now.Minute); // 0
            Console.Writeline(DateTime.Now.Second); // 0

            Console.Writeline(DateTime.Now.DayOfWeek); // Friday
            Console.Writeline(DateTime.Now.DayOfYear); // 267

            Console.Writeline(DateTime.Now.ToLongDateString()); // 24 Eylül 2021 Cuma
            Console.Writeline(DateTime.Now.ToShortDateString()); // 24.09.2021
            Console.Writeline(DateTime.Now.ToLongTimeString()); // 11:00:00
            Console.Writeline(DateTime.Now.ToShortTimeString()); // 11:00

            Console.Writeline(DateTime.Now.AddDays(2)); // 26.09.2021 11:00:00
            Console.Writeline(DateTime.Now.AddHours(3)); // 24.09.2021 14:00:00
            Console.Writeline(DateTime.Now.AddMonths(5)); // 24.02.2022 11:00:00
            Console.Writeline(DateTime.Now.AddYears(10)); // 24.09.2031 11:00:00
            Console.Writeline(DateTime.Now.AddSeconds(30)); // 24.09.2021 11:00:30

            //DateTime Format
            Console.Writeline(DateTime.Now.ToString("dd")); // 24
            Console.Writeline(DateTime.Now.ToString("ddd")); // Cum
            Console.Writeline(DateTime.Now.ToString("dddd")); // Cuma

            Console.Writeline(DateTime.Now.ToString("MM")); // 09
            Console.Writeline(DateTime.Now.ToString("MMM")); // Eyl
            Console.Writeline(DateTime.Now.ToString("MMMM")); // Eylül

            Console.Writeline(DateTime.Now.ToString("yy")); // 21
            Console.Writeline(DateTime.Now.ToString("yyyy")); // 2021

            //Math Kütüphanesi
            Console.Writeline(Math.Abs(-25)); // 25
            Console.Writeline(Math.Sin(10)); // -0,5440211108893698
            Console.Writeline(Math.Cos(10)); // -0,8390715290764524
            Console.Writeline(Math.Tan(10)); // 0,6483608274590866

            Console.Writeline(Math.Ceiling(22.3)); // 23
            Console.Writeline(Math.Round(22.3)); // 22
            Console.Writeline(Math.Round(22.7)); // 23
            Console.Writeline(Math.Floor(22.7)); // 22

            Console.Writeline(Math.Max(2,6)); // 6
            Console.Writeline(Math.Min(2,6)); // 2

            Console.Writeline(Math.Pow(3,4)); // 81
            Console.Writeline(Math.Sqrt(9)); // 3
            Console.Writeline(Math.Log(9)); // 2,1972245773362196
            Console.Writeline(Math.Exp(3)); // 20,085536923187668
            Console.Writeline(Math.Log10(10)); // 1

            

        }

    }
}