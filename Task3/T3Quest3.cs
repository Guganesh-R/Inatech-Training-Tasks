using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class T3Quest3
    {
        class login
        {
            string email = "Guganesh2002@gmail.com";
            string pass = "Gugan@123";
            int pin = 1357;
            int pin_num = 1357;
            string Mid = "Gugan";
            long mobile = 12345;
            public void validate(string mail, string pwd)
            {
                this.email = mail;
                this.pass = pwd;
                if (mail == email && pwd == pass)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine("Incorrect email or password!!!");
                }
            }
            public void validate(string Mship, int Pin)
            {
                this.Mid = Mship;
                this.pin = Pin;
                if (Mship == Mid && Pin == pin)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine("Incorrect email or password!!!");
                }
            }
            public void validate(long Mobile, int pnum)
            {
                this.mobile = Mobile;
                this.pin_num = pnum;
                if (Mobile == mobile && pnum == pin_num)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine("Incorrect email or password!!!");
                }
            }
            internal class LoginTask
            {
                public static void Main(string[] args)
                {
                    login obj = new login();
                    Console.WriteLine("Enter Login Credentials:");
                    Console.WriteLine("A.Login with Email id and password\t");
                    Console.WriteLine("B.Login with Membership id and pin\t");
                    Console.WriteLine("C.Login with Mobile no and pin\t");
                    string ch = Console.ReadLine();
                    switch (ch)
                    {
                        case "A":
                            Console.WriteLine("Enter Email id:");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter password:");
                            string pass = Console.ReadLine();
                            obj.validate(email, pass);
                            break;

                        case "B":
                            Console.WriteLine("Enter Membership id:");
                            string Mid = Console.ReadLine();
                            Console.WriteLine("Enter pin:");
                            int pin = Convert.ToInt32(Console.ReadLine());
                            obj.validate(Mid, pin);
                            break;

                        case "C":
                            Console.WriteLine("Enter mobile number:");
                            long mb = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter pin");
                            int Pin = Convert.ToInt32(Console.ReadLine());
                            obj.validate(mb, Pin);
                            break;

                        default:
                            Console.WriteLine("Invalid choice!!!");
                            break;
                    }
                }
            }
        }
    }
}
