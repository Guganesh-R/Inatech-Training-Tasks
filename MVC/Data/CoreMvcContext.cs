using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMvc.Models;

namespace CoreMvc.Data
{
    public class CoreMvcContext : DbContext
    {
        public CoreMvcContext (DbContextOptions<CoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMvc.Models.Customer> Customer { get; set; } = default!;

        public DbSet<CoreMvc.Models.MembershipDetail> MembershipDetail { get; set; }

        public DbSet<CoreMvc.Models.MembershipFee> MembershipFee { get; set; }
    }
}
