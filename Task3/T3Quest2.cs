using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class T3Quest2
    {
        class vtaxtaxcalculation
        {
            public void calculatetax(double vat, double price)
            {
                double Vattax = (vat / 100) * price;
                Console.WriteLine(Vattax);
            }
        }
        public class gsttaxcalculation 
        {
            public void calculatetax(double gst, double price)
            {
                double Gsttax= (gst/100) * price;
                Console.WriteLine(Gsttax);
            }
            
        }
        public static void Main(string[] args)
        {
            vtaxtaxcalculation vobj = new vtaxtaxcalculation();
            vobj.calculatetax(20, 1000);
            gsttaxcalculation gobj= new gsttaxcalculation();
            gobj.calculatetax(12, 1000);
        }
    }
}
