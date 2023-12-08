using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class RolesModule
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Modules { get; set; }
        public string RoleId { get; set; }

        public IdentityRole Role { get; set; }
    }
}
