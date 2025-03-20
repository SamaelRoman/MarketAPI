using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ProductIMGDTO
    {
        /// <summary>
        /// Идентификатор изображения
        /// </summary>
        public Guid id { get; set; }
        /// <summary>
        /// Продукт к которому относится изображение
        /// </summary>
        public ProductDTO product { get; set; }
        /// <summary>
        /// Название файла изображения
        /// </summary>
        public string name { get; set; }
    }
}
