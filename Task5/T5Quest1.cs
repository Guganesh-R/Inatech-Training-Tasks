using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class T5Quest1
    {
        string name;
        int age;
        public void nameandage()
        {
            Console.WriteLine("Entre your name:");
            string name = Console.ReadLine();
            Console.WriteLine("entre your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0} your age is {1} ", name, age);
        }
        public void nameandage(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Hello {0} your age is {1} ", name, age);


        }
        public static void Main(string[] args)
        {
            T5Quest1 obj = new T5Quest1();
            obj.nameandage();
            obj.nameandage("Guganesh", 21);
        }
    }
}

