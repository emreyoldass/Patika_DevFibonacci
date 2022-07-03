using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciDizisiOrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> dizi = new List<float>();

            fibonacci _fibonacci = new fibonacci();
            float ort = 0;
            float sonuc = 0;

            Console.WriteLine("Derinlik giriniz");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                dizi.Add(_fibonacci.createarray());
            }
            Console.Write("1,");
            Console.WriteLine(string.Join(',', dizi.ToArray()));

            for (int i = 0; i < sayi; i++)
            {
                ort += dizi[i];
                sonuc = Queryable.Average(dizi.AsQueryable());

            }
            Console.WriteLine("");
            Console.WriteLine("Ortalama: " + sonuc);
        }
    }
}
