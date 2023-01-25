using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class T4Quest1
    {
        public abstract class Membership
        {

            public abstract void Membershiptype();
        }
        public class GoldMembership : Membership
        {
            public override void Membershiptype()
            {
                Console.WriteLine("5 days accomodation at resort and 2 dinners on the house");
            }
        }
        public class SilverMembership : Membership
        {
            public override void Membershiptype()
            {
                Console.WriteLine("3 days accomodation at resort");
            }
        }
        public class PlatinumMembership : Membership
        {
            public override void Membershiptype()
            {
                Console.WriteLine("7 days accomodation at resort and 5 dinners on the house");
            }
        }
        public class MembershipImplementation
        {

            public static void Main(string[] args)
            {
                Console.WriteLine("Entre the Membership preference\t 1.Gold\t 2.Silver\t 3.Platinum");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        GoldMembership gobj = new GoldMembership();
                        gobj.Membershiptype();
                        break;
                    case 2:
                        SilverMembership sobj = new SilverMembership();
                        sobj.Membershiptype();
                        break;
                    case 3:
                        PlatinumMembership pobj = new PlatinumMembership();
                        pobj.Membershiptype();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
            }

            //public static void Main(string[] args)
            //{
            //    GoldMembership g = new GoldMembership();
            //    g.Membershiptype();
            //    SilverMembership s = new SilverMembership();
            //    s.Membershiptype();
            //    PlatinumMembership p = new PlatinumMembership();
            //    p.Membershiptype();
            //}
        }
    }
}
