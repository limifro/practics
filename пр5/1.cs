using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr5_1
{
    interface IAnimal
    {
        void Voice();
    }
    class Vorona: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Êàð!");
        }
    }
    class Cat: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Ìÿó!");
        }
    }
    class Snake: IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("CCCCCCCCC!");
            }
            else
            {
                Console.WriteLine("ØØØØØ!");
            }
        }
    }
    class Dog: IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Ãàâ!");
        }
    }
    class Horse : IAnimal
    {
        public void Voice()
        {
            bool animalIsFree = true;
            if (animalIsFree)
            {
                Console.WriteLine("Èãîãî!");
            }
            else
            {
                Console.WriteLine("Ïôôô!");
            }
        }
    }
    internal class Program
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Ìû ãëàäèì çâåðþøêó, à îíà íàì ãîâîðèò:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Vorona());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Snake());
            myAnimals.Add(new Dog());
            myAnimals.Add(new Horse());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}
