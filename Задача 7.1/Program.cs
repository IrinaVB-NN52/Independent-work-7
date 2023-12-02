using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._1
{
    internal class Program
    {
        static double GetgetTriangle(double a, double b, double c)
        {
            double p = (a + b + c)/2;
            double S =  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите длины первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double c1 = GetgetTriangle(x1, y1, z1);
            Console.WriteLine("Ведите длины второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double c2 = GetgetTriangle(x2, y2, z2);

            if(c1>c2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if(c1<c2)
                Console.WriteLine("Площадь первого треугольника меньше");
            else
                Console.WriteLine("Площадь треугольников равны");
            Console.ReadKey();


        }
    }
}
