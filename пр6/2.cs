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
            Console.WriteLine("�� �������� �� ������ ��������� ������ ������");
        }
        public PolytechCar (string name, int speed) : base (name, speed)
        {
        }
    }
    class Airplane : TransportVehicle
    {
        public void PollinateField()
        {
            Console.WriteLine("���� ������� �������");
        }
        public Airplane (string name, int speed) : base (name, speed)
        {
        }
    }
    class ConcreteMixer: TransportVehicle
    {
        public void MixConcrete()
        {
            Console.WriteLine("������ �����");
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
            PolytechCar Polytech = new PolytechCar("�������-������-1", 100);
            Polytech.TurnMusic();
            Airplane Boeing = new Airplane("��-34", 1200);
            Boeing.PollinateField();
            ConcreteMixer beton = new ConcreteMixer("�������������", 150);
            beton.MixConcrete();
            Console.ReadKey(true);
        }
    }
}