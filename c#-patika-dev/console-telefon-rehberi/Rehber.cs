using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberiUygulamasi
{
    class Rehber
    {
        private List<Kisi> kisiler;

        public Rehber()
        {
            kisiler = new List<Kisi>()
            {
                new Kisi("Ahmet", "Yılmaz", "1111111111"),
                new Kisi("Mehmet", "Demir", "2222222222"),
                new Kisi("Ayşe", "Kara", "3333333333"),
                new Kisi("Fatma", "Yılmaz", "4444444444"),
                new Kisi("Ali", "Can", "5555555555")
            };

            Calistir();
        }

        public void Calistir()
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("***************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Programdan Çık");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        YeniNumaraKaydet();
                        break;
                    case 2:
                        NumaraSil();
                        break;
                    case 3:
                        NumaraGuncelle();
                        break;
                    case 4:
                        RehberiListele();
                        break;
                    case 5:
                        RehberdeArama();
                        break;
                    case 0:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                        break;
                }
            }
        }

        private void YeniNumaraKaydet()
        {
            Console.Write("Lütfen isim giriniz: ");
            string isim = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            string soyisim = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz: ");
            string telefon = Console.ReadLine();

            Kisi yeniKisi = new Kisi(isim, soyisim, telefon);
            kisiler.Add(yeniKisi);

            Console.WriteLine("Yeni numara kaydedildi.");
        }

        private void NumaraSil()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string aranan = Console.ReadLine();

            Kisi bulunanKisi = kisiler.FirstOrDefault(kisi =>
                kisi.Isim.Equals(aranan, StringComparison.OrdinalIgnoreCase) ||
                kisi.Soyisim.Equals(aranan, StringComparison.OrdinalIgnoreCase));

            if (bulunanKisi == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("Lütfen bir seçim yapınız:");
                Console.WriteLine("(1) Silmeyi sonlandırmak için");
                Console.WriteLine("(2) Yeniden denemek için");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        break;
                    case 2:
                        NumaraSil();
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                        break;
                }
            }
            else
            {
                Console.Write($"{bulunanKisi.Isim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n): ");
                string onay = Console.ReadLine();

                if (onay.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    kisiler.Remove(bulunanKisi);
                    Console.WriteLine("Kişi rehberden silindi.");
                }
                else
                {
                    Console.WriteLine("İşlem iptal edildi.");
                }
            }
        }

        private void NumaraGuncelle()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string aranan = Console.ReadLine();

            Kisi bulunanKisi = kisiler.FirstOrDefault(kisi =>
                kisi.Isim.Equals(aranan, StringComparison.OrdinalIgnoreCase) ||
                kisi.Soyisim.Equals(aranan, StringComparison.OrdinalIgnoreCase));

            if (bulunanKisi == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("Lütfen bir seçim yapınız:");
                Console.WriteLine("(1) Güncellemeyi sonlandırmak için");
                Console.WriteLine("(2) Yeniden denemek için");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        break;
                    case 2:
                        NumaraGuncelle();
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen yeni telefon numarasını giriniz: ");
                string yeniTelefon = Console.ReadLine();

                bulunanKisi.Telefon = yeniTelefon;
                Console.WriteLine("Kişinin numarası güncellendi.");
            }
        }

        private void RehberiListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***************************************");

            foreach (Kisi kisi in kisiler)
            {
                Console.WriteLine($"isim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarası: {kisi.Telefon}");
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        private void RehberdeArama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
            Console.WriteLine("***************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    IsmeGoreAra();
                    break;
                case 2:
                    TelefonaGoreAra();
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    break;
            }
        }

        private void IsmeGoreAra()
        {
            Console.Write("Lütfen arama yapmak istediğiniz isim veya soyisimi giriniz: ");
            string aranan = Console.ReadLine();

            List<Kisi> bulunanKisiler = kisiler.Where(kisi =>
                kisi.Isim.Contains(aranan, StringComparison.OrdinalIgnoreCase) ||
                kisi.Soyisim.Contains(aranan, StringComparison.OrdinalIgnoreCase)).ToList();

            if (bulunanKisiler.Count == 0)
            {
                Console.WriteLine("Aranan kriterlere uygun veri bulunamadı.");
            }
            else
            {
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("***************************************");

                foreach (Kisi kisi in bulunanKisiler)
                {
                    Console.WriteLine($"isim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarası: {kisi.Telefon}");
                }
            }
        }

        private void TelefonaGoreAra()
        {
            Console.Write("Lütfen arama yapmak istediğiniz telefon numarasını giriniz: ");
            string aranan = Console.ReadLine();

            Kisi bulunanKisi = kisiler.FirstOrDefault(kisi =>
                kisi.Telefon.Equals(aranan, StringComparison.OrdinalIgnoreCase));

            if (bulunanKisi == null)
            {
                Console.WriteLine("Aranan kriterlere uygun veri bulunamadı.");
            }
            else
            {
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("***************************************");
                Console.WriteLine($"isim: {bulunanKisi.Isim} Soyisim: {bulunanKisi.Soyisim} Telefon Numarası: {bulunanKisi.Telefon}");
            }
        }
    }
}
