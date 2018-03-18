using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            var ans = DateTime.IsLeapYear(int.Parse(n));
            if(ans)
            {
                Console.WriteLine("你輸入的是閏年");
            }
            else
            {
                Console.WriteLine("你輸入的'不'是閏年");
            }
            Console.ReadLine();
        }
    }
}
