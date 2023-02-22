using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINKQPrograms
{
    internal class Linkq2
    {
        public static void Main(string[] args)
        {
            food[] foods =
            {
            new food() { ItemID = 1, ItemName = "Oreo Shake" },
            new food() { ItemID = 2, ItemName = "Mango Shake" },
            new food() { ItemID = 3, ItemName = "Grape Juice" },
            new food() { ItemID = 4, ItemName = "Pomogranate Juice" }
        };
            var qry = from shakes in foods
                      where shakes.ItemName.Contains(" Shake")
                      select shakes;
            foreach (var shak in qry)
            {
                Console.WriteLine(shak.ItemName);
            }
            Console.WriteLine("Filtering by name");
            Console.WriteLine("Healthy Foods are");
            
            var goodfood = foods.Where(f => f.ItemName.Contains("Juice"));
            foreach (food hf in goodfood)
            {
                Console.WriteLine(hf.ItemName);
            }
           
            Console.WriteLine("filtering by id");
            var fo = foods.Where((j, i) =>
            {
                if (i % 2 == 0)
                    return true;
                return false;
            });
            foreach(food fs in fo)
            {
                Console.WriteLine(fs.ItemName);
            }
        }
    }
    class food
    {
        public int ItemID { get; set; }
        public string? ItemName { get; set; }
    }
}

