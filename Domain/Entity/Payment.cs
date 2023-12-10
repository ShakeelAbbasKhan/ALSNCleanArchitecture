using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string Narration { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        public string AdminId { get; set; }
        public string PartyId { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public ApplicationUser AdminUser { get; set; }
        public ApplicationUser PartyUser { get; set; }
        public List<PaymentDetail> PaymentDetails { get; set; }
    }
}
