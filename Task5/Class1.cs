using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task5
{
    internal class Task5a
    {
        string name;
        int age;
        public Task5a()
        {
            name = "SJ";
            age = 23;
        }
        public Task5a(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static void Main(string[] args)
        {
            Task5a obj = new();
            Console.WriteLine("By initializing object\n" + obj.name + " " + obj.age);
            Task5a obj1 = new("Vigneshwar", 23);
            Console.WriteLine("By passing parameters\n" + obj1.name + " " + obj.age);
        }
    }
}