using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06CountHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入西元xxxx年 將會顯示該年週六週日有幾天");
            string n = Console.ReadLine();
            DateTime startDate = new DateTime(int.Parse(n),01,01);
            DateTime endDate = new DateTime(int.Parse(n), 12, 31);
            int Sunday = 0;
            int Saturday = 0;
            
            while (startDate < endDate)
            {
                if ((int)startDate.DayOfWeek == 0)
                {
                    Sunday += 1;
                }
                if ((int)startDate.DayOfWeek == 6)
                {
                    Saturday += 1;
                }

                startDate = startDate.AddDays(1);

            }
            Console.WriteLine("星期六有:" + Saturday + "天" + "星期日有:" + Sunday + "天");
            Console.ReadLine();
        }
    }
}
