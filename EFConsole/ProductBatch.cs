using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFConsole.Models;

namespace EFConsole
{
    internal class ProductBatch
    {
        [Key] public int Id { get; set; }
        [Required] [StringLength(50)] public string Name { get; set; }
        public int quantity { get;set; }
        public double price { get; set; }
        [ForeignKey("ProductID")] 
        public Product ProductIDs { get; set; }        

    }
}
