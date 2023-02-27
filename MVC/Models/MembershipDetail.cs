using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMvc.Models
{
    public class MembershipDetail
    {
        [Key]
        public int MembershipId { get; set; }
        [ForeignKey("Customer")]
        public int CustmID { get; set; }

        public Customer ? Customer { get; set; }
       
        [ForeignKey("MembershipFee")]
        public int MembershipType { get; set; }

        public MembershipFee ? MembershipFee { get; set; }
    }
}
