
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class ProductDTO
    {
        /// <summary>
        ///Идентификатор продукта в БД 
        /// </summary>
        public Guid id { get; set; }
        /// <summary>
        /// Идентификатор привязки одинаковых товаров с различеями в характеристиках
        /// </summary>
        public Guid groupBindingId { get; set; }
        /// <summary>
        /// идентификатор языка продукта, является ID из таблицы Language
        /// </summary>
        public int LanguageID { get; set; }
        /// <summary>
        /// Язык продукта ( название, описание, и прочие характеристики зависящие от языка) навигационное свойство
        /// </summary>
        public LanguageDTO Language { get; set; }
        /// <summary>
        ///Название продукта 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Фото товара
        /// </summary>
        public IEnumerable<ProductIMGDTO> productIMGs { get; set; }
        /// <summary>
        /// Описание товара
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// Цена товара
        /// </summary>
        public decimal price { get; set; }
        /// <summary>
        /// Кол-во в наличии
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// Характеристики товара
        /// </summary>
        public IEnumerable<ParameterValueDTO> ParameterValues { get; set; }
        /// <summary>
        /// идентификатор категории продукта является ID из таблицы Category
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// Категория продукта навигационное  свойство
        /// </summary>
        public CategoryDTO Category { get; set; }
        /// <summary>
        /// идентификатор бренда продукта является ID из таблицы Brand может быть null
        /// </summary>
        public int? BrandID { get; set; }
        /// <summary>
        /// Бренд ( производитель товара)
        /// </summary>
        public BrandDTO Brand { get; set; }
        public ProductDTO()
        {
            productIMGs = new List<ProductIMGDTO>();
            ParameterValues = new List<ParameterValueDTO>();

        }
    }
}
