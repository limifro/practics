using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_1
{
    class Magia
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        private string Effect
        {
            get;
            set;
        }
        public Magia(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
    class chel
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        public chel(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine("{0} колдует!", Name);
                spell.Use();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine("Для использования {0} не хватает {1} единиц маны. Хлебните зелья!", spell.Name, mana);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Magia alohomora = new Magia("абракадабра", 60, "Челоке превращается в жабу");
            Magia vingardiumLeviosa = new Magia("фокус покус", 60, "Предмет изчезает");
            chel malfoi = new chel("Малфой", 100);
            malfoi.CastSpell(alohomora);
            malfoi.CastSpell(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}