using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1
{
    internal class Quest2
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Do you have any travel history  Yes:No");
            string ans = Console.ReadLine();
            if (ans == "Yes" | ans == "YEs" | ans == "YES" | ans == "yES" | ans == "yeS" | ans=="yes")
            {
                Console.WriteLine("Do you have temperature?  Yes:No");
                string ans1 = Console.ReadLine();
                if (ans1 == "Yes" | ans1 == "YEs" | ans1 == "YES" | ans1 == "yES" | ans1 == "yeS" | ans1 == "yes")
                {
                    Console.WriteLine("Do you have Cough or sneez   Yes:No");
                    string ans2 = Console.ReadLine();
                    if (ans2 == "Yes" | ans2 == "YEs" | ans2 == "YES" | ans2 == "yES" | ans2 == "yeS" | ans2 == "yes")
                    {
                        Console.WriteLine("Take a SWAB TEST");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine Yourself and take Fever medicines");
                    }
                }
                else
                {       Console.WriteLine("Home Qurantine for 28 Days");
                }
            }
            else
            {
                Console.WriteLine("Not COVID-19");
            }
        }
    }
}
