using System;
using System.Collections.Generic;
using System.IO;

namespace ATMUygulamasi
{
    class Program
    {
        static Dictionary<string, decimal> hesaplar = new Dictionary<string, decimal>();
        static string kullaniciAdi;

        static void Main(string[] args)
        {
            hesaplar.Add("user1", 1000);
            hesaplar.Add("user2", 2000);

            Console.WriteLine("ATM'ye Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Giriş yap");
                Console.WriteLine("2. Para çekme");
                Console.WriteLine("3. Para yatırma");
                Console.WriteLine("4. Ödeme yapma");
                Console.WriteLine("5. Diğer işlemler");
                Console.WriteLine("6. Gün sonu al");

                Console.Write("Seçiminizi yapın (1-6): ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        GirisYap();
                        break;
                    case "2":
                        ParaCek();
                        break;
                    case "3":
                        ParaYatir();
                        break;
                    case "4":
                        OdemeYap();
                        break;
                    case "5":
                        DigerIslemler();
                        break;
                    case "6":
                        GunSonuAl();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
                string devamEt = Console.ReadLine();

                if (devamEt.ToLower() != "e")
                    break;

                Console.Clear();
            }

            Console.WriteLine("İyi günler!");
        }

        static void GirisYap()
        {
            Console.Write("Kullanıcı adınızı girin: ");
            string girisKullaniciAdi = Console.ReadLine();

            if (hesaplar.ContainsKey(girisKullaniciAdi))
            {
                kullaniciAdi = girisKullaniciAdi;
                Console.WriteLine("Giriş başarılı!");
            }
            else
            {
                Console.WriteLine("Bu kullanıcı adı kayıtlı değil!");
                Console.WriteLine("Yeni bir hesap oluşturmak istiyor musunuz? (E/H)");
                string yeniHesap = Console.ReadLine();

                if (yeniHesap.ToLower() == "e")
                {
                    Console.Write("Kullanıcı adınızı girin: ");
                    string yeniKullaniciAdi = Console.ReadLine();

                    if (!hesaplar.ContainsKey(yeniKullaniciAdi))
                    {
                        hesaplar.Add(yeniKullaniciAdi, 0);
                        kullaniciAdi = yeniKullaniciAdi;
                        Console.WriteLine("Yeni hesap oluşturuldu ve giriş yapıldı!");
                    }
                    else
                    {
                        Console.WriteLine("Bu kullanıcı adı zaten kayıtlı!");
                    }
                }
            }
        }

        static void ParaCek()
        {
            Console.Write("Çekmek istediğiniz miktarı girin: ");
            decimal cekilecekMiktar = Convert.ToDecimal(Console.ReadLine());

            if (hesaplar[kullaniciAdi] >= cekilecekMiktar)
            {
                hesaplar[kullaniciAdi] -= cekilecekMiktar;
                Console.WriteLine("Para çekme işlemi başarılı!");
                Console.WriteLine("Yeni bakiyeniz: " + hesaplar[kullaniciAdi]);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        static void ParaYatir()
        {
            Console.Write("Yatırmak istediğiniz miktarı girin: ");
            decimal yatirilacakMiktar = Convert.ToDecimal(Console.ReadLine());

            hesaplar[kullaniciAdi] += yatirilacakMiktar;
            Console.WriteLine("Para yatırma işlemi başarılı!");
            Console.WriteLine("Yeni bakiyeniz: " + hesaplar[kullaniciAdi]);
        }

        static void OdemeYap()
        {
            Console.Write("Ödemek istediğiniz miktarı girin: ");
            decimal odemeMiktari = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Alıcı bilgilerini girin: ");
            string alici = Console.ReadLine();

            if (hesaplar[kullaniciAdi] >= odemeMiktari)
            {
                hesaplar[kullaniciAdi] -= odemeMiktari;
                hesaplar[alici] += odemeMiktari;
                Console.WriteLine("Ödeme işlemi başarılı!");
                Console.WriteLine("Yeni bakiyeniz: " + hesaplar[kullaniciAdi]);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        static void DigerIslemler()
        {
            Console.WriteLine("Diğer işlemler için pre-defined işlem listesi kullanılabilir.");
        }

        static void GunSonuAl()
        {
            Console.WriteLine("Gün sonu alınıyor...");

            string logDosyaAdi = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";

            using (StreamWriter writer = new StreamWriter(logDosyaAdi))
            {
                writer.WriteLine("Transaction Logları:");

                foreach (KeyValuePair<string, decimal> hesap in hesaplar)
                {
                    writer.WriteLine("Kullanıcı: " + hesap.Key + ", Bakiye: " + hesap.Value);
                }

                writer.WriteLine();
                writer.WriteLine("Hatalı Giriş Denemeleri Logları:");

                // Hatalı giriş denemeleri loglarını buraya yazın
            }

            Console.WriteLine("Gün sonu alındı! Loglar " + logDosyaAdi + " dosyasına kaydedildi.");
        }
    }
}
