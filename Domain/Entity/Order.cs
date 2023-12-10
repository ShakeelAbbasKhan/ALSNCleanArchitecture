using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string DocumentType { get; set; }
        public string AttachmentDocument { get; set; }
        public decimal CommissionAmount { get; set; }
        public string Status { get; set; }
        public string GuestID { get; set; }
        public string TranslationOfficeID { get; set; }

        public ApplicationUser GuestUser { get; set; }
        public ApplicationUser TranslationOfficeUser { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<OrderAssignment> OrderAssignments { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Chat> Chats { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
