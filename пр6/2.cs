using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_2
{
    class TransportVehicle
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public TransportVehicle (string name, int speed)
        {
            Name = name;
            MaxSpeed = speed;
        }
    }
    class PolytechCar : TransportVehicle
    {
        public void TurnMusic()
        {
            Console.WriteLine("Вы включили на полную громкость плохую музыку");
        }
        public PolytechCar (string name, int speed) : base (name, speed)
        {
        }
    }
    class Airplane : TransportVehicle
    {
        public void PollinateField()
        {
            Console.WriteLine("Поле успешно опылили");
        }
        public Airplane (string name, int speed) : base (name, speed)
        {
        }
    }
    class ConcreteMixer: TransportVehicle
    {
        public void MixConcrete()
        {
            Console.WriteLine("Мешаем бетон");
        }
        public ConcreteMixer (string name, int speed) : base (name, speed)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportVehicle Car = new TransportVehicle("KIA K5", 350);
            PolytechCar Polytech = new PolytechCar("Политех-машина-1", 100);
            Polytech.TurnMusic();
            Airplane Boeing = new Airplane("Юг-34", 1200);
            Boeing.PollinateField();
            ConcreteMixer beton = new ConcreteMixer("Бетономешалка", 150);
            beton.MixConcrete();
            Console.ReadKey(true);
        }
    }
}