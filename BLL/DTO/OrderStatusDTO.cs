using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class OrderStatusDTO
    {
        public Int16 id { get; set; }
        public LanguageDTO language { get; set; }
        public string orderSatusName { get; set; }
        public IEnumerable<OrderDTO> Orders { get; set; }
    }
}
