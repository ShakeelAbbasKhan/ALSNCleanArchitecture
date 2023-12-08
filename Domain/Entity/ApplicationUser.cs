using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Status { get; set; }
        public int? UserTypeId { get; set; }
        public int? CountryId { get; set; }

        // Navigation properties
        public UserTypes UserTypes { get; set; }
        public Country Country { get; set; }

        public List<Translator> Translators { get; set; }

        public List<TranslationOfficeTranslators> TranslationOfficeTranslators { get; set; }
        public List<Order> Orders { get; set; }
        public List<Order> OrdersTranslator { get; set; }
        public List<OrderAssignment> OrderAssignments { get; set; }
    }
}
