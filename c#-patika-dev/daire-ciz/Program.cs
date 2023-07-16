using System;

namespace DaireCizimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını girin: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            DaireCizici daireCizici = new DaireCizici();
            daireCizici.DaireCiz(yaricap);
        }
    }

    class DaireCizici
    {
        public void DaireCiz(double yaricap)
        {
            int daireCevresi = (int)Math.Ceiling(2 * Math.PI * yaricap);

            for (int satir = 1; satir <= daireCevresi; satir++)
            {
                for (int sutun = 1; sutun <= daireCevresi; sutun++)
                {
                    double uzaklik = Math.Sqrt(Math.Pow(satir - yaricap, 2) + Math.Pow(sutun - yaricap, 2));
                    if (Math.Abs(uzaklik - yaricap) < 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
