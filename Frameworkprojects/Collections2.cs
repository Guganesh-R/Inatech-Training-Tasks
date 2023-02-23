using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Frameworkprojects
{
    internal class Collections2
    {
        public static void Main(string[] args)
        {
            List<string> l1 = new List<string>();
            l1.Add("AAA");
            l1.Add("BBB");
            l1.Add("CCC");
            l1.Add("DDD");
            foreach(string s in l1) 
            {
                Console.WriteLine(s);   
            }
            LinkedList<double> l2 = new LinkedList<double>();
            l2.AddFirst(98.02);
            var nnode=l2.AddLast(100.01);
            l2.AddLast(102.11);
            l2.AddBefore(nnode, 99.1);
            l2.AddAfter(nnode, 101.1);
            foreach (double d in l2)
            {
                Console.WriteLine(d);
            }
                     //key,value//

            Dictionary<int,string> d1= new Dictionary<int,string>();
            d1.Add(1,"guganesh");
            d1.Add(2, "vignesh");
            d1.Add(3, "vignesh");
            d1.Add(4, "prathibha");
            d1.Add(5, "bhoomica");
            foreach(var x in d1) 
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key);
                Console.WriteLine(x.Value);
            }
        }

    }
}
