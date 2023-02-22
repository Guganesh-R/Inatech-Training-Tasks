using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFConsole.Models;

namespace EFConsole
{
    internal class Program1
    {
        public static void InsertProduct()
        {
            using (var DbCon = new ProductContext())
            {
                Product product= new Product ();
                product.Name = "Mysore Sandl";
                DbCon.Add (product);
                product = new Product();
                product.Name = "Santoor";
                DbCon.Add (product);
                DbCon.SaveChanges();
            }
            return;
        }
        public static void ReadProduct()
        {
            using(var DbCon = new ProductContext()) 
            {
                List<Product> prod = DbCon.Products.ToList();
                foreach (var pr in prod)
                {
                    Console.WriteLine(pr.Name);
                }
            }
          
        }
        public static void UpdateProduct() 
        {
            using (var dbCon = new ProductContext()) 
            {
                Product ? prd = dbCon.Products.Find(3);
                prd.Name = "Dove";
                dbCon.SaveChanges();
            }
        }
        public static void DeleteProduct() 
        {
            using ( var dbCon= new ProductContext() )
            {
                Product? produ = dbCon.Products.Find(4);
                dbCon.Products.Remove(produ);
                dbCon.Products.Remove(dbCon.Products.Find(5));
                dbCon.SaveChanges();
            }
        }
        public static void InsertBatch()
        {
            using (var DbCon = new ProductContext())
            {
                ProductBatch Batch = new ProductBatch();
                Batch.Id = 1;
                DbCon.Add(Batch);
                Batch = new ProductBatch();
                Batch.Name = "A1";
                DbCon.Add(Batch);
                Batch = new ProductBatch();
                Batch.quantity = 200;
                DbCon.Add(Batch);
                Batch = new ProductBatch();
                Batch.price = 1000.00;
                DbCon.Add(Batch);
                Batch = new ProductBatch();
               // Batch.ProductIDs = 1001;
                DbCon.Add(Batch);
                DbCon.SaveChanges();
            }
            return;
        }
        public static void InsertStudent()
        {
            using (var Dbcon = new ProductContext())
            {
                Student sobj = new Student();
                //sobj.StudId = 1;
                //Dbcon.Add(sobj);
                sobj.StudName = "Gugan";
                Dbcon.Add(sobj);
                sobj.refID = 1;
                Dbcon.Add(sobj);
                Dbcon.SaveChanges();

            }
        }

        public static void InsertStandard()
        {
            using (var Dbcon = new ProductContext())
            {
                Standard stdobj = new Standard();
                stdobj.Standname = 333;
                Dbcon.Add(stdobj);
                stdobj = new Standard();
                stdobj.Standname = 444;
                Dbcon.Add(stdobj);
                Dbcon.SaveChanges();
            }
        }

        public static void ReadStudent()
        {
            using (var DbCon = new ProductContext())
            {
                List<Student> students = DbCon.Students.ToList();
                foreach (var pr in students)
                {
                    Console.WriteLine(pr.StudName+" "+ pr.StudId);
                }
            }

        }
        public static void Main(string[] args)
        {
            //InsertProduct();
            //Console.WriteLine("Success");
            //UpdateProduct();
            ////DeleteProduct();
            //ReadProduct();
            //InsertBatch();
            InsertStudent();
            //InsertStandard();
            ReadStudent();
        }
    }
}
