using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class UserTypes
    {
        public int Id { get; set; }
        public string userTypeTitle { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string LanguageExpertise { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }
    }
}
