using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class T2Quest4
    {
        public static void Main(string[] args)
        {
            double tot = 0; 
            double percentage=0;
            double[] marks = new double[] { 95.5, 95.5, 100, 90, 99.5 };
            for(int i=0;i<marks.Length;i++)
            {
                Console.WriteLine(marks[i]);
                tot += marks[i];
                percentage = (tot / 500) * 100;
                
            }
            Console.WriteLine(tot);
            Console.WriteLine(percentage);

        }
    }
}
