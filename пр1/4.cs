using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_4
{
    class Mashina
    {
        public string name;
        public double maxSpeed;
        private double _time;
        public double time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = CalculateTime(value);
            }
        }
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfoCar()
        {
            Console.WriteLine($"Название автомобиля: {name}, Максимальная скрость: {maxSpeed}.");
        }
        public Mashina()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 150;
            this.time = 0;
        }
        public Mashina(string name, double speed, double time)
        {
            this.name = name;
            this.maxSpeed = speed;
            this.time = time;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mashina[] cars = new Mashina[4];
            double distance = 400;
            Mashina astonMartin = new Mashina("KIA K5", 220, distance);
            cars[0] = astonMartin;
            Mashina audi = new Mashina("Toyota supra A80", 340, distance);
            cars[1] = audi;
            Mashina ford = new Mashina("Nissan Teana", 150, distance);
            cars[2] = ford;
            Mashina bugatti = new Mashina("Nissan Myrano", 400, distance);
            cars[3] = bugatti;
            double[] races = new double[4];
            for (int i = 0; i < cars.Length; i++)
            {
                races[i] = cars[i].time;
            }
            Array.Sort(races);
            for (int i = 0; i < races.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (races[i] == cars[j].time)
                    {
                        Console.WriteLine($"{i+1} место занимает автомобиль {cars[j].name} с максимальной скоростью {cars[j].maxSpeed}, преодолев {distance} км за {Math.Round(cars[j].time, 2)} ч.");
                    }
                }
            }
            Console.ReadKey(true);
        }
    }
}