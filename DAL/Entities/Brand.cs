using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Brand
    {
        /// <summary>
        /// Идентификатор бренда (производителя)
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название бренда (производителя)
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Описание бренда (производителя)
        /// </summary>
        public string description { get; set; }
        
    }
}
