using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個數字");
            var n = Console.ReadLine();
            int value = int.Parse(n);

            Console.WriteLine();
            for (int i=1;i<=int.Parse(n);i++)
            {
                for(int j=value;j<=int.Parse(n);j++)
                {
                    Console.Write(value);
                }
                Console.WriteLine();
                value -= 1;
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
