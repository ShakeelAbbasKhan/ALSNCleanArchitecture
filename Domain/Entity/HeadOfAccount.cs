using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class HeadOfAccount
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string ParentAccount { get; set; }
        public DateTime ValidityFrom { get; set; }
        public DateTime ValidityTo { get; set; }
        public List<PaymentDetail> PaymentDetails { get; set; }
    }
}
