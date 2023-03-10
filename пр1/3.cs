using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_3
{
    class Mashina
    {
        public string name;
        public double maxSpeed;
        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void InfoCar()
        {
            Console.WriteLine($"Название автомобиля: {name}, Максимальная скорость: {maxSpeed}.");
        }
        public Mashina()
        {
            this.name = "Автомобиль";
            this.maxSpeed = 150;
        }
        public Mashina(string name, double speed)
        {
            this.name = name;
            this.maxSpeed = speed;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
