using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkprojects
{
    internal class collection1
    {
        public static void Main(string[] args)
        { 
            Queue q1= new Queue();
            q1.Enqueue("AAA");
            q1.Enqueue("BBB");
            q1.Enqueue("CCC");
            q1.Enqueue("DDD");
            q1.Enqueue("EEE");
            int tcount = q1.Count;
            Console.WriteLine(tcount);
            for (int i = 0; i < tcount; i++)
                Console.WriteLine(q1.Peek());// peek only gets the first element of the queue
            Console.WriteLine("---------");
            foreach(object obj in q1)
                Console.WriteLine(q1.Peek());// peek only gets the first element of the queue
            Console.WriteLine("---------");
            for (int i=0;i<tcount;i++)
                Console.WriteLine(q1.Dequeue());
            Console.WriteLine("---------");

        }
    }
}
