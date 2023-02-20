using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("** Türkçe Kitaplar Kategorisi          **  Yabancı Kitaplar Kategorisi          **");
            Console.WriteLine();
            Console.WriteLine("** 1-Çalıkuşu: Reşat Nuri              **  7- Tuna Kılavuzu: Jules Verne        **");
            Console.WriteLine();
            Console.WriteLine("** 2-Yaban: Yakup Kadri                **  8- Bir Kuzey Macerası: Jack London   **");
            Console.WriteLine();
            Console.WriteLine("** 3-Sinekli Bakkal: Halide Edip       **  9- Altıncı Koğuş: Anton Çehov        **");
            Console.WriteLine();
            Console.WriteLine("** 4-Tehlikeli Oyunlar: Oğuz Atay      **  10- Kumarbaz: Dostoyevski            **");
            Console.WriteLine();
            Console.WriteLine("** 5-Kara Kitap: Orhan Pamuk           **  11- İki Şehrin Hikayesi: C.Dickens   **");
            Console.WriteLine();
            Console.WriteLine("** 6- İntibah: Namık Kemal             **  12- Vişne Bahçesi: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("*****İşlemler Menüsü******");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemin numarası:");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')//if yapısı içinde switch case kullanuıldı.
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını girin: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu :12 TL"); break;
                    case "2": Console.Write("Yaban :14 TL"); break;
                    case "3": Console.Write("Sinekli Bakkal :16 TL"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar :11 TL"); break;
                    case "5": Console.Write("Kara Kitap :8 TL"); break;
                    case "6": Console.Write("İntibah :13 TL"); break;
                    case "7": Console.Write("Tuna Kılavuzu :18 TL"); break;
                    case "8": Console.Write("Bir Kuzey Macerası :20 TL"); break;
                    case "9": Console.Write("Altıncı Koğuş :21 TL"); break;
                    case "10": Console.Write("Kumarbaz :9 TL"); break;
                    case "11": Console.Write("İki Şehrin Hikayesi :24 TL"); break;
                    case "12": Console.Write("Vişne Bahçesi :12 TL"); break;
                    default: Console.Write("Böyle bir kitap mevcut değil, numarayı kontrol edin"); break;

                }

            }
            if (islem == '2')
            {
                Console.WriteLine();
                Console.WriteLine("*****Yeni Okur Kaydı*****");
                string ad, soyad, universite;//kullanıcı bilgileri string ile tutuldu
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();

                string dosya = @"C:\\Users\\furkan.karatas\\Desktop\\Kullanıcı.txt";//dosya yolu oluşturuldu
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                Console.WriteLine("Günün Kitabı: Kumarbaz");
                Console.WriteLine();
                Console.WriteLine("******************************");

            }
            if (islem == '4')//dosya yolu kullanarak veri çekme uygulandı
            {
                Console.WriteLine();
                Console.WriteLine("******************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\furkan.karatas\Desktop\Kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();

                //burası kitap arşivi
                Console.WriteLine();
                Console.WriteLine("******************************");
            }
            if (islem == '5')//toplam fiyat hesaplama(seçilen kitaplara göre)
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası:");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else if (secim == "2")
                    {
                        toplamfiyat = toplamfiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 18;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 20;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 21;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 9;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 24;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else

                        Console.WriteLine("Böyle bir kitap numarası yok");
                    Console.WriteLine();
                    Console.WriteLine("Başka bir kitap almak ister misiniz?");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                        break;



                }
                Console.WriteLine("Toplam Tutar:" + toplamfiyat);
            }
            if (islem == '6')//sayı tahmin oyunu
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while (sayi != tahmin)
                {
                    Console.WriteLine("Sayi giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha küçük-> ");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha büyük-> ");
                    }
                    if (tahmin == sayi)
                    {
                        Console.Write("Bildiniz..");
                        break;
                    }
                }
            }

            Console.Read();
        }
    }
}
