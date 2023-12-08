using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public DateTime Timestamp { get; set; }
        public long NoOfWords { get; set; }
        public bool IsFreeAmendments { get; set; }
        public bool IsPaid { get; set; }
        public long PaymentAmount { get; set; }
        public int SourceLanguageId { get; set; }
        public int TargetLanguageId { get; set; }

        public Language SourceLanguage { get; set; }
        public Language TargetLanguage { get; set; }
        public int OrderId { get; set; }
        public Order Orders { get; set; }
        public int OrderRepitionID { get; set; }
        public OrderRepitition OrderRepitition { get; set; }
    }
}
