using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Category
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Язык категории 
        /// </summary>
        public int languageId { get; set; }
        /// <summary>
        /// Язык навигационнлое свойство
        /// </summary>
        public Language language { get; set; }
        /// <summary>
        /// Название категории
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Описание категории
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Навигационное свойство
        /// </summary>
        public IEnumerable<Product> Products{ get; set; }

    }
}
