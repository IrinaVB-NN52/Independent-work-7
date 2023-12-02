using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._2
{
    internal class Program
    {
        static void GetCube(double l, out double s, out double v)
        {
            s = 6 * l *l;
            v = l * l * l;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double l = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetCube(l, out s, out v);
            Console.WriteLine("{0:.00} {1:.00}", s, v);
            Console.ReadKey();
        }
    }
}
