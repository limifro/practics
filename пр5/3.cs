using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter: IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            char[] symbols = {' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?'};
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsLetter(textline[i]) || Array.IndexOf(symbols, textline[i]) >= 0)
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    class LetterFilter: IFilter
    {
        public string Execute(string textline)
        {
            string str = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    str += textline[i];
                }
            }
            return str;
        }
    }
    internal class Programa
    {
        static void Main(string[] args)
        {
            DigitFilter stringLetters = new DigitFilter();
            Console.WriteLine(stringLetters.Execute("Недостаточно подрезать дерево, чтобы оно зацвело: необходимо еще вмешательство весны890347."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("3Ско7лько7 4р3аз3 7нуж8но3 4умер5еть1, 8что4бы8 3научи6ться4 5жи5ть?8"));
            Console.ReadKey(true);
        }
    }
}