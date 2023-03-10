using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_1
{
    class kvadrat
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double x1;
        private double x2;
        private double CalculateDiscriminant()
        {
            d = Math.Pow(b, 2) - 4 * a * c;
            return d;
        }
        void CalculateRoots()
        {
            this.d = CalculateDiscriminant();
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            } else if (d == 0) {
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            } else
            {
                Console.WriteLine("��������� �� ����� ������.");
            }
        }
        public void GetRoots()
        {
            CalculateRoots();
        }
        public kvadrat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            kvadrat equation = new kvadrat(1, -1, -6);
            equation.GetRoots();
            Console.ReadKey(true);
        }
    }
}