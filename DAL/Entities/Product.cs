using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
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
        public Language Language { get; set; }
        /// <summary>
        ///Название продукта 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Фото товара
        /// </summary>
        public IEnumerable<ProductIMG> productIMGs { get; set; }
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
        public IEnumerable<ParameterValue> ParameterValues { get; set; }
        /// <summary>
        /// идентификатор категории продукта является ID из таблицы Category
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// Категория продукта навигационное  свойство
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// идентификатор бренда продукта является ID из таблицы Brand может быть null
        /// </summary>
        public int? BrandID { get; set; }
        /// <summary>
        /// Бренд ( производитель товара)
        /// </summary>
        public Brand Brand { get; set; }
        public Product()
        {
            productIMGs = new List<ProductIMG>();
            ParameterValues = new List<ParameterValue>();

        }
    }
}
