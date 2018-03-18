using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = { };
            
            int j = 0;
            Console.WriteLine("輸入一個字串 並用逗號隔開");

            n = Console.ReadLine().ToString().Split(',');
            string[] m = new string[n.Length];
            for(int i=n.Length-1;i>=0;i--)
            {
                m[j] = n[i];
                j++;
            }

            for (int i = 0; i <= m.Length - 1; i++)
            {
                Console.Write(m[i]);
                if (i != m.Length - 1)
                    Console.Write(",");
            }

            Console.ReadLine();

        }
    }
}
