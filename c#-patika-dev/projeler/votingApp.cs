using System;
using System.Collections.Generic;

namespace VotingUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> kategoriler = new Dictionary<string, int>()
            {
                { "Film Kategorileri", 0 },
                { "Tech Stack Kategorileri", 0 },
                { "Spor Kategorileri", 0 }
            };

            Dictionary<string, string> kullaniciKayitlari = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("Voting Uygulamasına Hoş Geldiniz!");
                Console.WriteLine("1. Yeni kullanıcı kaydı yap");
                Console.WriteLine("2. Kategorileri listele ve oy ver");
                Console.WriteLine("3. Uygulamadan çık");

                Console.Write("Seçiminizi yapın (1-3): ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Write("Kullanıcı adınızı girin: ");
                    string kullaniciAdi = Console.ReadLine();

                    if (!kullaniciKayitlari.ContainsKey(kullaniciAdi))
                    {
                        kullaniciKayitlari.Add(kullaniciAdi, kullaniciAdi);
                        Console.WriteLine("Kayıt işlemi başarılı! Kaldığınız yerden devam edebilirsiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Bu kullanıcı adı zaten kayıtlı!");
                    }
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Kategoriler:");
                    int index = 1;
                    foreach (string kategori in kategoriler.Keys)
                    {
                        Console.WriteLine(index + ". " + kategori);
                        index++;
                    }

                    Console.Write("Oy vermek istediğiniz kategori numarasını girin: ");
                    int secilenKategoriIndex = Convert.ToInt32(Console.ReadLine());

                    if (secilenKategoriIndex >= 1 && secilenKategoriIndex <= kategoriler.Count)
                    {
                        string secilenKategori = GetKategoriByIndex(kategoriler, secilenKategoriIndex);
                        kategoriler[secilenKategori]++;
                        Console.WriteLine("Oy verme işlemi başarılı!");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz kategori numarası!");
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Uygulamadan çıkılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                }
            }

            Console.WriteLine("Oylama Sonuçları:");
            foreach (string kategori in kategoriler.Keys)
            {
                int toplamOy = kategoriler[kategori];
                double oyYuzdesi = (toplamOy / (double)kullaniciKayitlari.Count) * 100;

                Console.WriteLine(kategori + ":");
                Console.WriteLine("Toplam Oy Sayısı: " + toplamOy);
                Console.WriteLine("Oy Yüzdesi: " + oyYuzdesi.ToString("F2") + "%");
                Console.WriteLine();
            }
        }

        static string GetKategoriByIndex(Dictionary<string, int> kategoriler, int index)
        {
            int counter = 1;
            foreach (string kategori in kategoriler.Keys)
            {
                if (counter == index)
                    return kategori;

                counter++;
            }

            return string.Empty;
        }
    }
}
