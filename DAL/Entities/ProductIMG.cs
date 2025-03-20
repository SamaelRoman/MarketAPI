using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductIMG
    {
        /// <summary>
        /// Идентификатор изображения
        /// </summary>
        public Guid id { get; set; }
        /// <summary>
        /// Продукт к которому относится изображение
        /// </summary>
        public Product product { get; set; }
        /// <summary>
        /// Название файла изображения
        /// </summary>
        public string name { get; set; }
    }
}
