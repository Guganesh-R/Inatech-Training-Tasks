using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.Models
{
    public class Student
    {
        [Key]
        public int StudId { get; set; }
        public string ? StudName { get; set; }
        
        [ForeignKey("Standard")]

        public int refID { get; set; }  

        public Standard Standard { get; set; }
    }
    public class Standard 
    {
        [Key]
        public int StdId { get; set; }
        public int Standname { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
