using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework07ArabicNumerals
{
    class Program
    {
        public static Dictionary<int, ArabicNumerals> _Number = new Dictionary<int, ArabicNumerals>();
        static void Main(string[] args)
        {
            CreateDictionary();
            Console.WriteLine("輸入四個數字");
            int m = int.Parse(Console.ReadLine());
            Call(m);
            Console.ReadLine();
        }

        public static void Call(int n)
        {
            int t1 = n / 1000;
            int t2 = n % 1000 / 100;
            int t3 = n % 100 / 10;
            int t4 = n % 10;
            Console.Write(_Number[t1].GetWord);
            Console.Write(_Number[t2].GetWord);
            Console.Write(_Number[t3].GetWord);
            Console.Write(_Number[t4].GetWord);
        }

        public static Dictionary<int, ArabicNumerals> CreateDictionary()
        {
            //Dictionary<int, ArabicNumerals> _Number = new Dictionary<int, ArabicNumerals>();
            _Number = new Dictionary<int, ArabicNumerals>();
            {
                _Number.Add(0, new ArabicNumerals { number = 0, word = "零" });
                _Number.Add(1, new ArabicNumerals { number = 1, word = "一" });
                _Number.Add(2, new ArabicNumerals { number = 2, word = "二" });
                _Number.Add(3, new ArabicNumerals { number = 3, word = "三" });
                _Number.Add(4, new ArabicNumerals { number = 4, word = "四" });
                _Number.Add(5, new ArabicNumerals { number = 5, word = "五" });
                _Number.Add(6, new ArabicNumerals { number = 6, word = "六" });
                _Number.Add(7, new ArabicNumerals { number = 7, word = "七" });
                _Number.Add(8, new ArabicNumerals { number = 8, word = "八" });
                _Number.Add(9, new ArabicNumerals { number = 9, word = "九" });
            }
            return _Number;
        }
    }
}

