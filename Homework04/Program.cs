using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list =  Console.ReadLine().Split(',').ToList();
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            int n = 0;
            foreach(string i in list)
            {
                if (int.Parse(i)%2 !=0)
                {
                    odd.Add(int.Parse(list[n]));
                    n++;
                }
                else
                {
                    even.Add(int.Parse(list[n]));
                    n++;
                }
            }
            odd.Sort();
            even.Sort();

            Console.Write("奇數的字串是:");
            for (int i = 0; i < odd.Count; i++)
            {
                Console.Write(odd[i]);
                if (i != odd.Count - 1)
                {
                    Console.Write(",");
                }
            }


            Console.Write("偶數的字串是:");
            for (int i = 0; i < even.Count; i++)
            {
                Console.Write(even[i]);
                if (i != even.Count - 1)
                {
                    Console.Write(",");
                }
            }

            Console.ReadLine();

        }
    }
}
