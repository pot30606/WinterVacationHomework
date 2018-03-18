using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06_2CountHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入民國xx年 將會顯示該年週六週日有幾天");
            string n = Console.ReadLine();
            int year = int.Parse(n) + 1911;
            DateTime startDate = new DateTime(year, 01, 01);
            DateTime endDate = new DateTime(year, 12, 31);
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
