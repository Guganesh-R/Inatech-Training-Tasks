using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LINKQPrograms.Linkq1;

namespace LINKQPrograms
{
    internal class Linkq3
    {
        public static void Main(string[] args)
        {
            Student[] stud =
                {
                new Student() { StudentId = 1, StudentName = "Guganesh", age = 22, BranchID=1 },
                new Student() { StudentId = 2, StudentName = "Chitra", age = 23, BranchID=2},
                new Student() { StudentId = 3, StudentName = "Reshma", age = 23,BranchID=1 },
                new Student() { StudentId = 4, StudentName = "thamarai", age = 24, BranchID=3 } };
        }
        IList<branch> branchedata = new List<branch>()
        {
            new branch() {BranchID=1,BranchName="EcE"},
            new branch() {BranchID=2,BranchName="IT"},
            new branch() {BranchID=3,BranchName="CSE"}

        };

        public class branch
        {
            public int BranchID { get; set; }
            public string? BranchName { get; set; }
        }
    }
}
