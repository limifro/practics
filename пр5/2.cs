using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_2
{
    interface IHello
    {
        void SayHello();
    }
    class Russian: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class English: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Azerbaijani : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
    class Arameiski: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Shlomo");
        }
    }
    class Aragonski: IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Ola");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Russian());
            greetings.Add(new English());
            greetings.Add(new Azerbaijani());
            greetings.Add(new Arameiski());
            greetings.Add(new Aragonski());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}