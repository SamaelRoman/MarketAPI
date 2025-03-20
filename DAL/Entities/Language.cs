using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Language
    {
        /// <summary>
        /// Код языка (идентификатор)
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название языка
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Сокращенное название языка
        /// </summary>
        public string shortName { get; set; }
        /// <summary>
        /// Все продукты на данном языке
        /// </summary>
        public IEnumerable<Product> products { get; set; }

    }
}
