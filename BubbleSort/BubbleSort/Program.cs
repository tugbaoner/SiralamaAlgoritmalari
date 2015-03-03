using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Kaç elemanlı dizi olsun istersin?");
            int sayi = Convert.ToInt32(Console.ReadLine()); // dizinin eleman sayısı klavyeden okunuyor.
            int[] Dizi = new int[sayi];
            int[] Dizi1 = new int[sayi];
            
            int gecici;
            int comparison_bub = 0;
            int swap_bub = 0;

            Random RasgeleSayi = new Random(); // randomla sayi üretmek için rasgele nesnesi oluşturuluyor.
            for (int i = 0; i < sayi; i++)
            {
                Dizi[i] = RasgeleSayi.Next(1, 100); // diziye dizinin eleman sayısı kadar 1 ile 100 arasında sayı atıyor.
                Dizi1[i] = RasgeleSayi.Next(1, 100);
            }
            for (int i = 1; i < Dizi.Length; i++)
            {
                for (int j = 0; j < Dizi.Length - i; j++)
                {
                    
                    comparison_bub = comparison_bub + 1;
                    if (Dizi[j] > Dizi[j + 1])
                    {
                        swap_bub = swap_bub + 1; 
                        gecici = Dizi[j + 1];
                        Dizi[j + 1] = Dizi[j];
                        Dizi[j] = gecici;
                    }
                }
            }
            int comparison_sel = 0;
            int swap_sel = 0;
            int gecici1;
            int enkucuk;

            for (int i = 0; i < Dizi1.Length - 1; i++)
            {
                enkucuk = i;
                for (int j = (i + 1); j < Dizi1.Length; j++)
                {
                    comparison_sel = comparison_sel + 1;
                    if (Dizi1[j] < Dizi1[enkucuk])
                    {
                        swap_sel = swap_sel + 1;
                        enkucuk = j;
                    }
                }
                gecici1 = Dizi1[i];
                Dizi1[i] = Dizi1[enkucuk];
                Dizi1[enkucuk] = gecici1;
            }

            Console.WriteLine("comparison_bub=" + comparison_bub);
            Console.WriteLine("swap_bub=" + swap_bub);

            Console.WriteLine("comparison_sel=" + comparison_sel);
            Console.WriteLine("swap_sel=" + swap_sel);

            Console.ReadLine();
        }

       


    }
}
