using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Feedback
    {
        public int Id { get; set; }
        public DateTime FeedbackDate { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public string GuestId { get; set; }
        public ApplicationUser GuestUser { get; set; }
    }
}
