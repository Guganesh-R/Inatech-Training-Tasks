using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class T2Quest2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre the number ");
            int num= Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(num + "* {0}", i +"=" + num*i);
            }
        }
        
    }
}
