using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_3
{
    class Ork
    {
        private static int Counter;
        public static int amountGoldAll
        {
            get;
            private set;
        }
        public int amountGold
        {
            get;
            private set;
        }
        public Ork()
        {
            Counter++;
            amountGoldAll += 2;
            if (Counter > 5)
            {
                amountGold += 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ork ork_1 = new Ork();
            Console.WriteLine(Orc.amountGoldAll);
            Ork ork_2 = new Ork();
            Ork ork_3 = new Ork();
            Console.WriteLine(Orc.amountGoldAll);
            Ork ork_4 = new Ork();
            Ork ork_5 = new Ork();
            Ork ork_6 = new Ork();
            Console.WriteLine(ork_6.amountGold);
            Console.ReadKey(true);
        }
    }
}