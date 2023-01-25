using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1
{
    internal class Quest1
    {
        public static void Main(string[] args)
        {
            double cost;
            Console.WriteLine("ENTER NUMBER OF UNITS CONSUMED");
            double units = Convert.ToDouble(Console.ReadLine());
            if (units <= 200)
            {
                cost = units * 2;
                Console.WriteLine("the cost of power consumption is {0}", cost);
            }
            else if (units > 200 && units <= 350)
            {
                cost = 400 + ((units - 200) * 3);
                Console.WriteLine("the cost of power consumption is {0}", cost);
            }
            else if (units > 350 && units <= 500)
            {
                cost = 400 + 447 + ((units - 350) * 5);
                Console.WriteLine("the cost of power consumption is {0}", cost);
            }
            else if (units > 500)
            {
                cost = 400 + 447 + 745 + ((units - 500) * 7);
                Console.WriteLine("the cost of power consumption is { 0 }", cost);
            }
        }
    }
}
