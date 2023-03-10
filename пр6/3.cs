using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_3
{
    class chel
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public chel (string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    class Worker : chel
    {
        public string Position
        {
            get;
            set;
        }
        public Worker (string name, int age, char gender, string position) : base (name, age, gender)
        {

            Position = position;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            chel Liza = new chel("Елизавета Игнатова", 18, 'Ж');
            Console.WriteLine(Alexander.Name);
            Worker Karina = new Worker("Карина Захарова", 19, 'Ж', "Программист");
            Console.WriteLine(Karina.Position);
            Console.ReadKey(true);
        }
    }
}