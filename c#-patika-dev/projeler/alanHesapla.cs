using System;

namespace GeometrikHesaplamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geometrik şekli girin: ");
            string sekil = Console.ReadLine();

            double sonuc = 0.0;

            if (sekil == "Daire")
            {
                double yaricap = KenarBilgisiAl("Yarıçap");
                sonuc = DaireAlanHesapla(yaricap);
            }
            else if (sekil == "Üçgen")
            {
                double kenar1 = KenarBilgisiAl("Kenar 1");
                double kenar2 = KenarBilgisiAl("Kenar 2");
                double kenar3 = KenarBilgisiAl("Kenar 3");
                sonuc = UcgenCevreHesapla(kenar1, kenar2, kenar3);
            }
            else if (sekil == "Kare")
            {
                double kenar = KenarBilgisiAl("Kenar");
                sonuc = KareAlanHesapla(kenar);
            }
            else if (sekil == "Dikdörtgen")
            {
                double uzunKenar = KenarBilgisiAl("Uzun Kenar");
                double kisaKenar = KenarBilgisiAl("Kısa Kenar");
                sonuc = DikdortgenCevreHesapla(uzunKenar, kisaKenar);
            }
            else
            {
                Console.WriteLine("Geçersiz geometrik şekil.");
                return;
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }

        static double KenarBilgisiAl(string kenarAdi)
        {
            Console.Write(kenarAdi + " değerini girin: ");
            double kenar = Convert.ToDouble(Console.ReadLine());
            return kenar;
        }

        static double DaireAlanHesapla(double yaricap)
        {
            double alan = Math.PI * Math.Pow(yaricap, 2);
            return alan;
        }

        static double UcgenCevreHesapla(double kenar1, double kenar2, double kenar3)
        {
            double cevre = kenar1 + kenar2 + kenar3;
            return cevre;
        }

        static double KareAlanHesapla(double kenar)
        {
            double alan = Math.Pow(kenar, 2);
            return alan;
        }

        static double DikdortgenCevreHesapla(double uzunKenar, double kisaKenar)
        {
            double cevre = 2 * (uzunKenar + kisaKenar);
            return cevre;
        }
    }
}
