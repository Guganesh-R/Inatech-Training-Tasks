using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMvc.Models
{
    public class MembershipFee
    {
        [Key]
        public int MembershipType { get; set; }
        
        public string ?MembershipName { get; set; }
        public double Fee { get; set; }
        public ICollection<MembershipDetail>? MembershipDetail { get; set; }

    }
}
