using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_2
{
    class Posl
    {
        public string Description
        {
            get;
            private set;
        }
        public int Weight
        {
            get;
            private set;
        }
        public Posl(string description, int weight)
        {
            Description = description;
            Weight = weight;
        }
    }
    class Service
    {
        private static int LimitWeight;
        private const int Limit = 10;
        public void SendPosl(Posl posl)
        {
            LimitWeight += posl.Weight;
            if (LimitWeight >= Limit)
            {
                Console.WriteLine("Ошибка! Вес отправленных посылок превысил лимит, отправка прервана.");
            }
            else
            {
                Console.WriteLine("{0} весом {1} кг успешно отправлена.", posl.Description, posl.Weight);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Posl posl_1 = new Posl("Стандартная посылка №0000001", 4);
            Posl posl_2 = new Posl("Тяжеловесная посылка №0000002", 7);
            Service service = new Service();
            service.SendPosl(posl_1);
            service.SendPosl(posl_2);
            Console.ReadKey(true);
        }
    }
}
