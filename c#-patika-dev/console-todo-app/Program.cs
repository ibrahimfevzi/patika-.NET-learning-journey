using System;
using System.Collections.Generic;

namespace ConsoleTODOUygulamasi
{
    class Program
    {
        enum KartBuyukluk
        {
            XS = 1,
            S = 2,
            M = 3,
            L = 4,
            XL = 5
        }

        static Dictionary<int, string> takimUyeleri = new Dictionary<int, string>
        {
            { 1, "Ahmet" },
            { 2, "Mehmet" },
            { 3, "Ayşe" }
        };

        static Dictionary<string, List<Dictionary<string, string>>> todoBoard = new Dictionary<string, List<Dictionary<string, string>>>
        {
            { "TODO", new List<Dictionary<string, string>>
                {
                    new Dictionary<string, string>
                    {
                        { "Baslik", "Kart 1" },
                        { "Icerik", "Bu bir deneme kartıdır." },
                        { "AtananKisi", "Ahmet" },
                        { "Buyukluk", KartBuyukluk.M.ToString() }
                    },
                    new Dictionary<string, string>
                    {
                        { "Baslik", "Kart 2" },
                        { "Icerik", "Bu bir diğer deneme kartıdır." },
                        { "AtananKisi", "Mehmet" },
                        { "Buyukluk", KartBuyukluk.S.ToString() }
                    }
                }
            },
            { "IN PROGRESS", new List<Dictionary<string, string>>
                {
                    new Dictionary<string, string>
                    {
                        { "Baslik", "Kart 3" },
                        { "Icerik", "Bu bir deneme kartıdır." },
                        { "AtananKisi", "Ayşe" },
                        { "Buyukluk", KartBuyukluk.L.ToString() }
                    }
                }
            },
            { "DONE", new List<Dictionary<string, string>>() }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("TODO Uygulamasına hoş geldiniz!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        BoardListele();
                        break;
                    case "2":
                        KartEkle();
                        break;
                    case "3":
                        KartSil();
                        break;
                    case "4":
                        KartTasi();
                        break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                }
            }
        }

        static void BoardListele()
        {
            Console.WriteLine("Board Listeleme");
            Console.WriteLine("----------------");

            foreach (var line in todoBoard)
            {
                Console.WriteLine();
                Console.WriteLine($"{line.Key} Line");
                Console.WriteLine("************************");

                if (line.Value.Count == 0)
                {
                    Console.WriteLine("~ BOŞ ~");
                }
                else
                {
                    foreach (var kart in line.Value)
                    {
                        Console.WriteLine($"Başlık      : {kart["Baslik"]}");
                        Console.WriteLine($"İçerik      : {kart["Icerik"]}");
                        Console.WriteLine($"Atanan Kişi : {kart["AtananKisi"]}");
                        Console.WriteLine($"Büyüklük    : {kart["Buyukluk"]}");
                        Console.WriteLine("-");
                    }
                }
            }
        }

        static void KartEkle()
        {
            Console.WriteLine("Board'a Kart Eklemek");
            Console.WriteLine("--------------------");

            Console.Write("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            Console.Write("İçerik Giriniz: ");
            string icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
            int buyuklukSecim;

            while (!int.TryParse(Console.ReadLine(), out buyuklukSecim) || !Enum.IsDefined(typeof(KartBuyukluk), buyuklukSecim))
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen geçerli bir seçim yapınız.");
            }

            KartBuyukluk buyukluk = (KartBuyukluk)buyuklukSecim;

            Console.WriteLine("Kişi Seçiniz:");

            foreach (var takimUyesi in takimUyeleri)
            {
                Console.WriteLine($"{takimUyesi.Key}. {takimUyesi.Value}");
            }

            int atananKisiID;

            while (!int.TryParse(Console.ReadLine(), out atananKisiID) || !takimUyeleri.ContainsKey(atananKisiID))
            {
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen geçerli bir seçim yapınız.");
            }

            string atananKisi = takimUyeleri[atananKisiID];

            Dictionary<string, string> yeniKart = new Dictionary<string, string>
            {
                { "Baslik", baslik },
                { "Icerik", icerik },
                { "AtananKisi", atananKisi },
                { "Buyukluk", buyukluk.ToString() }
            };

            todoBoard["TODO"].Add(yeniKart);

            Console.WriteLine("Kart başarıyla eklendi.");
        }

        static void KartSil()
        {
            Console.WriteLine("Board'dan Kart Silmek");
            Console.WriteLine("---------------------");

            Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();

            bool kartSilindi = false;

            foreach (var line in todoBoard)
            {
                foreach (var kart in line.Value)
                {
                    if (kart["Baslik"] == baslik)
                    {
                        line.Value.Remove(kart);
                        kartSilindi = true;
                        break;
                    }
                }

                if (kartSilindi)
                    break;
            }

            if (kartSilindi)
            {
                Console.WriteLine("Kart başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
                Console.WriteLine("Lütfen bir seçim yapınız:");
                Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        break;
                    case "2":
                        KartSil();
                        break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                }
            }
        }

        static void KartTasi()
        {
            Console.WriteLine("Kart Taşımak");
            Console.WriteLine("-------------");

            Console.Write("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor. Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();

            bool kartBulundu = false;
            string eskiLineAdi = "";
            Dictionary<string, string> taşinacakKart = null;

            foreach (var line in todoBoard)
            {
                foreach (var kart in line.Value)
                {
                    if (kart["Baslik"] == baslik)
                    {
                        kartBulundu = true;
                        eskiLineAdi = line.Key;
                        taşinacakKart = kart;
                        break;
                    }
                }

                if (kartBulundu)
                    break;
            }

            if (kartBulundu)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("************************************");
                Console.WriteLine($"Başlık      : {taşinacakKart["Baslik"]}");
                Console.WriteLine($"İçerik      : {taşinacakKart["Icerik"]}");
                Console.WriteLine($"Atanan Kişi : {taşinacakKart["AtananKisi"]}");
                Console.WriteLine($"Büyüklük    : {taşinacakKart["Buyukluk"]}");
                Console.WriteLine();

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        todoBoard["TODO"].Add(taşinacakKart);
                        todoBoard[eskiLineAdi].Remove(taşinacakKart);
                        Console.WriteLine("Kart başarıyla taşındı.");
                        break;
                    case "2":
                        todoBoard["IN PROGRESS"].Add(taşinacakKart);
                        todoBoard[eskiLineAdi].Remove(taşinacakKart);
                        Console.WriteLine("Kart başarıyla taşındı.");
                        break;
                    case "3":
                        todoBoard["DONE"].Add(taşinacakKart);
                        todoBoard[eskiLineAdi].Remove(taşinacakKart);
                        Console.WriteLine("Kart başarıyla taşındı.");
                        break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
                Console.WriteLine("Lütfen bir seçim yapınız:");
                Console.WriteLine("* İşlemi sonlandırmak için: (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        break;
                    case "2":
                        KartTasi();
                        break;
                    default:
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        break;
                }
            }
        }
    }
}
