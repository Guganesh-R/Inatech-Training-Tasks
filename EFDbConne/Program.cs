using EFDbConne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbConne
{
    internal class Program
    {
        //public static void InsertDept()
        //{
        //    using (var Dbcon= new DivsambarContext())
        //    {
        //        Department Dobj= new Department();
        //        Dobj.DepartmentName = "ECE";
        //        Dbcon.Add(Dobj);
        //        Dobj= new Department();
        //        Dobj.DepartmentName = "CSE";
        //        Dbcon.Add(Dobj);
        //        Dobj= new Department();
        //        Dobj.DepartmentName = "IT";
        //        Dbcon.Add(Dobj);
        //        Dbcon.SaveChanges();

        //    }
        //}
        public static void InsertEmployee()
        {
            using (var Dbcon = new DivsambarContext())
            {
                Employee Eobj = new Employee();
                Eobj.EmpId = 1;
                //Dbcon.Add(Eobj);
                //Eobj = new Employee();
                Eobj.EmpName = "Guganesh";
                //Dbcon.Add(Eobj);
                //Eobj = new Employee();
                Eobj.Gender = "m";
                Eobj.DeptId = 51;
                Dbcon.Add(Eobj);
                Dbcon.SaveChanges();
                //  Eobj = new Employee();
                //Eobj.DeptId = 1;
            }
        }
        public static void Main(string[] args)
        {
            //InsertDept();
            InsertEmployee();
        }
    }
}
