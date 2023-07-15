/*
Aşağıdaki 3 soruyu ayrı ayrı console uygulamaları açarak yazınız. Koleksiyonlar-Soru-1, Koleksiyonlar-Soru-2, Koleksiyonlar-Soru-3 isimlerini kullanınız.

Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

*/

//Cevap 1:
//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)


using System;

namespace sorubir
{
class Program
{
static void Main(string[] args)
{

ArrayList asal = new ArrayList();
ArrayList asalolmayan = new ArrayList();
int sayac = 0;
int sayi = 0;
while (sayac < 20)
{
Console.Write("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 0)
{
if (sayi == 1)
{
asalolmayan.Add(sayi);
        }
        else
        {
            int sayac2 = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac2++;
                }
            }
            if (sayac2 == 0)
            {
                asal.Add(sayi);
            }
            else
            {
                asalolmayan.Add(sayi);
            }
        }
        sayac++;


    }
    else
    {
        Console.WriteLine("Negatif sayı giremezsiniz.");
    }

}
asal.Sort();
asal.Reverse();
asalolmayan.Sort();
asalolmayan.Reverse();
Console.WriteLine("Asal sayılar: ");
foreach (int item in asal)
{
    Console.WriteLine(item);
}
Console.WriteLine("Asal olmayan sayılar: ");
foreach (int item in asalolmayan)
{
    Console.WriteLine(item);
}
Console.WriteLine("Asal sayıların eleman sayısı: " + asal.Count);
Console.WriteLine("Asal olmayan sayıların eleman sayısı: " + asalolmayan.Count);
Console.WriteLine("Asal sayıların ortalaması: " + asal.Average());
Console.WriteLine("Asal olmayan sayıların ortalaması: " + asalolmayan.Average());
}
}
}


//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

using System;

namespace soruiki
{
class Program
{
static void Main(string[] args)
{
int[] sayilar = new int[20];
int[] enbuyuk = new int[3];
int[] enkucuk = new int[3];
int toplam = 0;
int toplam2 = 0;
for (int i = 0; i < 20; i++)
{
Console.Write("Sayı giriniz: ");
sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(sayilar);
Array.Reverse(sayilar);
for (int i = 0; i < 3; i++)
{
enbuyuk[i] = sayilar[i];
}
Array.Sort(sayilar);
for (int i = 0; i < 3; i++)
{
enkucuk[i] = sayilar[i];
}
foreach (int item in enbuyuk)
{
Console.WriteLine("En büyük sayılar: " + item);
toplam += item;
}
foreach (int item in enkucuk)
{
Console.WriteLine("En küçük sayılar: " + item);
toplam2 += item;
}

Console.WriteLine("En büyük sayıların ortalaması: " + toplam / 3);
Console.WriteLine("En küçük sayıların ortalaması: " + toplam2 / 3);
Console.WriteLine("En büyük ve en küçük sayıların ortalaması: " + (toplam + toplam2) / 6);
}
}
}


//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System;

namespace soruuc
{
class Program
{
static void Main(string[] args)
{
string cumle;
Console.Write("Cümle giriniz: ");
cumle = Console.ReadLine();
char[] sesliharfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
int sayac = 0;
foreach (char item in cumle)
{
foreach (char item2 in sesliharfler)
{
if (item == item2)
{
sayac++;
}
}
}
char[] sesliharfler2 = new char[sayac];
int sayac2 = 0;
foreach (char item in cumle)
{
foreach (char item2 in sesliharfler)
{
if (item == item2)
{
sesliharfler2[sayac2] = item;
sayac2++;
}
}
}
Array.Sort(sesliharfler2);
foreach (char item in sesliharfler2)
{
Console.WriteLine(item);
}
}
}
}

