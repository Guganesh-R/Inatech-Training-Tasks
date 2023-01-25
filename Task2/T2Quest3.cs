using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class T2Quest3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the package You want   Package A/Package B/Package C");
            string ch= Console.ReadLine();
            switch(ch) 
            {
                case "Package A":
                    Console.WriteLine(" This package has 3 types of Channels they are 1.SOUTH SPECIAL, 2.CHILDRESN'S SPECIAL, 3.MOVIES");
                    Console.WriteLine("THE RATE OF THIS OACKAGE IS RS.250");
                    break;
                case "Package B":
                    Console.WriteLine("This package has 4 types of channels they are 1.NEWS, 2.SPORTS, 3.MOVIES, 4.REGIONAL-2");
                    Console.WriteLine("THE RATE OF THIS PACKAGE IS RS.450");
                    break;
                case "Package C":
                    Console.WriteLine("This package has 3 types pf channel they are 1.DISCOVERY, 2.HISTOR, 3.NATIONAL");
                    Console.WriteLine("THE RATE OF THIS PACKAGE IS RS.350");
                    break;
                default:
                    Console.WriteLine("The package is not not a valid package");
                    break;

            }
        }
    }
}
