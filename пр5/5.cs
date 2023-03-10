using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_5
{
    interface IMagic
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    class Spell: IMagic
    {
        public string Name
        {
            get;
            set;
        }
        public int Mana
        {
            get;
            set;
        }
        private string Effect
        {
            get;
            set;
        }
        public magia(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void WriteInfo()
        {
            Console.WriteLine(Effect);
        }
    }
    class Magic
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
        public Magic(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void WriteInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Mana);
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine($"{Name} колдует!");
                spell.WriteInfo();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine($"Для использования {spell.Name} не хватает {mana} единиц маны. Хлебните зелья!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Spell alohomora = new Spell("фбракадабра", 60, "Человек превращается в жабу");
            Spell vingardiumLeviosa = new Spell("фокус покус", 60, "Предмет исчазает");
            Magic malfoi = new Magic("Малфой", 100);
            malfoi.CastSpell(alohomora);
            malfoi.CastSpell(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}
