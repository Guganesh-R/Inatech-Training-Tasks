using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINKQPrograms
{
    internal class Linkq1
    {
        public static void Main(string[] args)
        {
            string[] names = { "Guganesh", "thamarai", "chitra", "reshma" };
            var qry = from name in names         // from the collection names we are selecting each element  
                      where name.Contains("e")   // this statement selects names which contains letter 'e' in the name0
                      select name;
            foreach (var n in qry)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Students class members");
            Student[] stud =
            {
                new Student() { StudentId = 1, StudentName = "Guganesh", age = 22 },
                new Student() { StudentId = 2, StudentName = "Chitra", age = 23 },
                new Student() { StudentId = 3, StudentName = "Reshma", age = 23 },
                new Student() { StudentId = 4, StudentName = "thamarai", age = 24 } };
            foreach (Student s in stud)
            {
                Console.WriteLine(s.StudentId + " " + s.StudentName + " " + s.age);
            }
            var qr = from Student in stud
                     where Student.age > 22
                     select Student;
            foreach(Student s in stud)
            {
                Console.WriteLine(s.StudentName+" " + s.age);
            }

            Console.WriteLine("using method in query");
            var stu= from Student in stud
                     where Student.IsEligible(Student)
                     select Student;
            foreach( Student st in stu)
            {
                Console.WriteLine(st.StudentName+" "+st.age);
            }
            Console.WriteLine("multiple where statements");
            var ss =from Student in stud
                    where Student.age>22
                    where Student.age<=23
                    select Student;
            foreach(Student sss in ss)
            {
                Console.WriteLine(sss.StudentName + " " + sss.age);
            }
            IList hlist = new ArrayList();
            hlist.Add(1);
            hlist.Add(2);
            hlist.Add("Three");
            hlist.Add("four");
            hlist.Add(new Student() { StudentId = 1, StudentName = "prathibha", age = 22 });
            var hlistStu = from st in hlist.OfType<Student>()
                           select st;
            var hlistInt = from st in hlist.OfType<int>()
                           select st;
            var hlistVal = from st in hlist.OfType<String>()
                           select st;
            foreach (Student stus in hlistStu)

                Console.WriteLine(stus.StudentName);


            foreach (var x in hlistInt) Console.WriteLine(x);

            foreach (var z in hlistVal) Console.WriteLine(z);
            Console.WriteLine("student based list:");
            var stulist = from sl in stud
                          orderby sl.StudentName, sl.age
                          select sl;
            foreach (Student dent in stulist)
                Console.WriteLine(dent.StudentName + " " + dent.age);
        }


        public class Student
        {
            public int StudentId { get; set; }
            public string? StudentName { get; set; }
            public int age { get; set; }
            public static bool IsEligible(Student studs)
            {
                return studs.age > 21 && studs.age <= 23;
            }
            public int BranchID { get; set; }
            public string? BranchName { get; set; }
        }
    }
}

