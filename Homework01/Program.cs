using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("請輸入一個數字:");
            try
            {
                n = Console.ReadLine();
                if (int.Parse(n) % 2 == 0)
                    Console.WriteLine("你輸入的是偶數");
                else
                    Console.WriteLine("你輸入的是奇數");
            }
            catch
            {
                Console.WriteLine("格式錯誤請重新輸入");
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
