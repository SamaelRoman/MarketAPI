using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OrderStatus
    {
        public Int16 id { get; set; }
        public Language language { get; set; }
        public string orderSatusName { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
