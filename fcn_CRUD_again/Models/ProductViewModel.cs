using DAL.Entities;

namespace fcn_CRUD_again.Models
{
    public class ProductViewModel
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
        /// Язык продукта ( название, описание, и прочие характеристики зависящие от языка) навигационное свойство
        /// </summary>
        public int LanguageId { get; set; }
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
        /// Категория продукта навигационное  свойство
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Навзание категории
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Бренд ( производитель товара)
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// Название бредна
        /// </summary>
        public string brandName { get; set; }
    }
}
