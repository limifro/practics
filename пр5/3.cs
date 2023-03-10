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
            Console.WriteLine(stringLetters.Execute("������������ ��������� ������, ����� ��� �������: ���������� ��� ������������� �����890347."));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Execute("3���7����7 4�3��3 7���8��3 4����5���1, 8���4��8 3�����6����4 5��5��?8"));
            Console.ReadKey(true);
        }
    }
}