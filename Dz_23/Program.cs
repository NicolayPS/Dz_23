using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dz_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n=");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);
            Console.ReadKey();
        }

        static void Fact(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
                Thread.Sleep(150);
            }
            Console.Write("!n=");
            Console.WriteLine(f);
            
        }

        static async void FactAsync(int n)
        {
            await Task.Run(() => Fact(n));
        }
    }
}
