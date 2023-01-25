using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class T2Quest5
    {
        public static void Main(string[] args)
        {
            string[][] product = new string[4][];
            product[0] = new string[3]{ "List", "Product Category", "No.Of Items" };
            product[1] = new string[3]{"A", "Biscuits", "There are 4 items"};
            product[2] = new string[3]{"B", "Chocolates", "There are 5 items"};
            product[3] = new string[3] { "C", "Drinks", "There are 6 items" };
            for (int i = 0; i < product.Length; i++)
            {
                for(int j = 0; j < product[i].Length;j++)
                {
                    Console.Write(product[i][j]+"\t");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
