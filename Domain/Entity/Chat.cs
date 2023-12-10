using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Chat
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public int OrderID { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public Order Order { get; set; }
        public ApplicationUser SenderUser { get; set; }
        public ApplicationUser RecieverUser { get; set; }
    }
}
