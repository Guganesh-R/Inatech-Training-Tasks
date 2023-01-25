using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class T2Quest1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ENTRE YOUR NAME");
            string name= Console.ReadLine();
            Console.WriteLine("ENTRE YOUR AGE");
            int age= Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<age; i++) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
