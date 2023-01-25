using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class T3Quest1
    {
        class arithmetic
        {
            int result;
            public int addition(int num1, int num2)
            {
                result = num1 + num2;
                return result;
            }
            public int subtraction(int num1, int num2)
            {
                result = num1 - num2;
                return result;
            }

        }
        class arithmetic1 :arithmetic
            {
            int result;
            public int multiplication(int num1, int num2)
            {
                result = num1*num2;
                return result;
            }
            public int divisionof(int num1, int num2)
            {
                result = num1/num2;
                return result;
            }
            }
        public static void Main(string[] args)
        {
            arithmetic1 obj = new arithmetic1();
            Console.WriteLine("entre Number 1");
                int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entre number 2");
                int num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the arithemetic operation \t 1.Addition\t 2.Subtraction\t3.multipliction\t4.Division");
           int ch= Convert.ToInt32(Console.ReadLine()); 
            switch(ch)
            {
                case 1:
                    int aresult = obj.addition(num1,num2);
                    Console.WriteLine("Sum of two number {0} and {1} is {2}",num1,num2,aresult);
                    break;
                case 2:
                    int sresult = obj.subtraction(num1,num2);
                    Console.WriteLine("Sum of two number {0} and {1} is {2}", num1, num2, sresult);
                    break;
                case 3:
                    int mresult =obj.multiplication(num1,num2);
                    Console.WriteLine("Sum of two number {0} and {1} is {2}", num1, num2, mresult);
                    break;
                case 4:
                    int dresult = obj.divisionof(num1,num2);
                    Console.WriteLine("Sum of two number {0} and {1} is {2}", num1, num2, dresult);
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
        }
    }
}
