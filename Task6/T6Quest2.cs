using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class T6Quest2
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Empgender { get; set; }
        public int Empage { get; set; }

        public void readfEmp()
        {
            FileStream emp = new FileStream("C:\\Inatech Training\\VS Console app\\Guganesh1Emp.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(emp);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        }
        public static void Main(string[] args)
        {
            T6Quest2 emp = new T6Quest2();
            Console.WriteLine("Enter employee name:");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter employee gender:");
            emp.Empgender = Console.ReadLine();
            Console.WriteLine("Enter employee ID:");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee age:");
            emp.Empage = Convert.ToInt32(Console.ReadLine());

            FileStream Emp = new FileStream(@"C:\Inatech Training\VS Console app\Guganesh1Emp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Emp);
            sw.Write(emp.EmpName);
            sw.Write(emp.Empgender);
            sw.Write(emp.Empage);
            sw.Write(emp.EmpId);
            sw.Flush();
            sw.Close();
            Emp.Close();
            emp.readfEmp();
        }
    }
}
