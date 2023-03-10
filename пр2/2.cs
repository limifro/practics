using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    class nomer
    {
        private int n = 0;
        public int GetNumber(int nomer)
        {
            if (SetNumber(nomer))
            {
                this.n = nomer;
            } else
            {
                this.n = 0;
            }
            return this.n;
        }
        private bool SetNumber (int nomer)
        {
            if (nomer == this.n + 1)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            nomer num = new nomer();
            int nomer;
            for (int i = 1; i >= 0; i = num.GetNumber(nomer) +1)
            {
                Console.WriteLine($"¬ведите число {i}");
                nomer = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey(true);
        }
    }
}
