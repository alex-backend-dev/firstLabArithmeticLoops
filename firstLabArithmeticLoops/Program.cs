using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLabArithmeticLoops
{
    class Program
    {
        static long Fact(long value)
        {
            return (value == 0) ? 1 : value * Fact(value - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Ведите x: ");
            double x = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int n = 0; n <= k; n++)
                sum += (Math.Cos(n * (Math.PI / 4)) / Fact(n)) * Math.Pow(x, n);

            Console.WriteLine("Результат = {0}", sum.ToString());
            Console.ReadKey();
        }
    }
}