using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aritmetik_ortalama_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            for (int i=1; i <= 5; i++)
            {
                Console.Write("Bir sayı giriniz:");
                double not = Convert.ToDouble(Console.ReadLine());
                toplam += not;

            }
            double ortalama = toplam / 5;
            Console.WriteLine("ortalama" + ortalama);
            Console.Read();
        }
    }
}
