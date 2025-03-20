using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class CategoryDTO
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
        /// Название категории
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Описание категории
        /// </summary>
        public string description { get; set; }

    }
}
