using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];          
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {               
                sayi = rnd.Next(1, 100);

                a[i] = sayi;               
                Console.WriteLine(a[i]);
            }
            
            bool durum = true;
            Console.Write("Aranacak Değeri Giriniz : ");
            int aranan = Convert.ToInt32(Console.ReadLine());
            int aranan_deger = Array.IndexOf(a, aranan);
            foreach (int deger in a)
            {
                if (aranan == deger)
                    durum = false;
            }
            if (durum == true)
                Console.WriteLine("Değer Bulunamadı.");
            else
                Console.WriteLine("{0} Değeri Dizinin {1}. Sırasında Bulundu.", aranan, aranan_deger + 1);         
            Console.ReadKey();
        }
    }
}
