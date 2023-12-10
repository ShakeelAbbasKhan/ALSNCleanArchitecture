using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class UserBank
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string BranchCode { get; set; }
        public string BranchAddress { get; set; }
        public string UserId { get; set; }
        public string TranslationOfficeId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ApplicationUser TranslationUser { get; set; }
    }
}
