using DAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace fcn_CRUD_again.Models
{
    public class ProductCreateViewModel
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
        ///Название продукта 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Фото товара
        /// </summary>
        public IEnumerable<ProductIMGsViewModel> productIMGs { get; set; }
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
        public IEnumerable<ParameterValuesViewModel> ParameterValues { get; set; }
        /// <summary>
        /// идентификатор категории продукта является ID из таблицы Category
        /// </summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// идентификатор бренда продукта является ID из таблицы Brand может быть null
        /// </summary>
        public int? BrandID { get; set; }
    }
}
