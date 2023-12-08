using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class OrderRepitition
    {
        public int Id { get; set; }
        public int OrderRepitionNo { get; set; }
        public float OrderRepitionTimeLimitHrs { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
