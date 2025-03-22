using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class OrderProductDTO
    {
        /// <summary>
        /// идентификатор продукта в заказе
        /// </summary>
        public Guid id { get; set; }
        /// <summary>
        ///  идентификатор Заказа в котором содержится продукт 
        /// </summary>
        public Guid OrderID { get; set; }
        /// <summary>
        /// Заказ в котором содержится продукт
        /// </summary>
        public OrderDTO Order { get; set; }
        /// <summary>
        /// Идентифкатор заказаного продукта
        /// </summary>
        public Guid ProductID { get; set; }
        /// <summary>
        /// Заказаный продукт навигационное свойство
        /// </summary>
        public ProductDTO Product { get; set; }
        /// <summary>
        /// Количество продуктов в заказе
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// Итоговая сумма к оплате по данному товару
        /// </summary>
        public decimal totalPrice { get; set; }
        /// <summary>
        /// Валюта в которой производится оплата Должна быть общей для всех товаров в заказе
        /// </summary>
        public CurrencyDTO currency { get; set; }

    }
}
