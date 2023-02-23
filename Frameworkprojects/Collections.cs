using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkprojects
{
    internal class Collections
    {
        public static void Main(string[] args)
        {
            ArrayList li1 = new ArrayList();
            li1.Add(1);
            li1.Add("Two");
            li1.Add(4.0);
            for(int i=0; i < li1.Count; i++) 
                Console.WriteLine(li1[i]);
            Console.WriteLine("--------------");
            li1.Add(5); 
            // enhance forloop
            foreach(object obj in li1) 
                Console.WriteLine(obj);
            
            ArrayList li2 = new ArrayList();
            li2.Add("AAA");
            li2.Add("BBB");
            li2.Add("CCC");
            li2.Add("DDD");
            li2.Add("EEE");
            li1.AddRange(li2);
            Console.WriteLine("--------------");
            foreach(object obj in li1) 
                Console.WriteLine(obj);
            Console.WriteLine("--------------");
            li1.Remove("AAA");
            foreach (object obj in li1)
                Console.WriteLine(obj);
            Console.WriteLine("--------------");
            li1.RemoveAt(0);
            foreach (object obj in li1)
                Console.WriteLine(obj);
            Console.WriteLine("--------------");
            li1.Insert(0, "One");
            foreach (object obj in li1)
                Console.WriteLine(obj);
            Console.WriteLine("--------------");
            li1.Clear();
            foreach (object obj in li1)
                Console.WriteLine(obj);
            Console.WriteLine("--------------");
            
        }

    }
}
