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
                Console.WriteLine($"{Name} �������!");
                spell.WriteInfo();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine($"��� ������������� {spell.Name} �� ������� {mana} ������ ����. �������� �����!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Spell alohomora = new Spell("�����������", 60, "������� ������������ � ����");
            Spell vingardiumLeviosa = new Spell("����� �����", 60, "������� ��������");
            Magic malfoi = new Magic("������", 100);
            malfoi.CastSpell(alohomora);
            malfoi.CastSpell(vingardiumLeviosa);
            Console.ReadKey(true);
        }
    }
}
