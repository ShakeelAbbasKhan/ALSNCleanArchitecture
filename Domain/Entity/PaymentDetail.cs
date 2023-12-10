using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public int HeadOfAccountId { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public Payment Payment { get; set; }
        public HeadOfAccount HeadOfAccount { get; set; }
    }
}
