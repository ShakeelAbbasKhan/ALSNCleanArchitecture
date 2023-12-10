using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Attachment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string GuestId { get; set; }
        public string AdminId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public ApplicationUser GuestUser { get; set; }
        public ApplicationUser AdminUser { get; set; }
    }
}
