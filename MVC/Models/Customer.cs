
using System.ComponentModel.DataAnnotations;

namespace CoreMvc.Models
{
    public class Customer
    {
        [Key]
        public int CustID { get; set; }

        public string ?CustName { get; set; }
        public string ?Gender { get; set; }
        [ DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Subscriptiondate { get; set; }
        public string ?MobileNumber { get; set; }
        public ICollection<MembershipDetail>? MembershipDetail { get; set; }



    }
}
