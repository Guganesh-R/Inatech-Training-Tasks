using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class T6Quest1
    {
        public void readfDes()
        {

            FileStream Restar = new FileStream("C:\\Inatech Training\\VS Console app\\Guganesh1\\Deserts.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(Restar);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        
        }
        public static void Main(string[] args)
        {

            T6Quest1 obj = new T6Quest1();
            ArrayList deserts = new ArrayList();
            Console.WriteLine("Enter the no.of.desserts to be added");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < d; i++)
            {

                string des = Console.ReadLine();
                deserts.Add(des);
            
            }
            FileStream Restar = new FileStream(@"C:\Inatech Training\VS Console app\Guganesh1\Deserts.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Restar);
            foreach (object o in deserts)
            {

                sw1.Write(o);
            
            }
            sw1.Flush();
            sw1.Close();
            Restar.Close();

            obj.readfDes();
            FileInfo infoco = new FileInfo("C:\\Inatech Training\\VS Console app\\Guganesh1\\Deserts.txt");
            Console.WriteLine("size of file {0}", infoco.Length);
            Console.WriteLine("creation time{0}", infoco.CreationTime);


        }
    }
}
