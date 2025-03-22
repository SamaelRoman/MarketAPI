using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class OrderDTO
    {
        /// <summary>
        /// Идентификатор заказа в БД
        /// </summary>
        public Guid id { get; set; }
        /// <summary>
        /// Язык заказа
        /// </summary>
        public LanguageDTO language { get; set; }
        /// <summary>
        /// Имя заказчика
        /// </summary>
        public string nameOfСustomer { get; set; }
        /// <summary>
        /// Отчество заказчика
        /// </summary>
        public string secondNameOfСustomer { get; set; }
        /// <summary>
        /// Фамилия заказчика
        /// </summary>
        public string surNameOfСustomer { get; set; }
        /// <summary>
        /// Адресс доставки заказа
        /// </summary>
        public string deliveryAddress { get; set; }
        /// <summary>
        /// Город доставки заказа
        /// </summary>
        public string deliveryCity { get; set; }
        /// <summary>
        /// Номер телефона зказчика
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Статус заказ идентификатор из таблицы OrderStatus
        /// </summary>
        public Int16 OrderStatusID{ get; set; }
        /// <summary>
        /// Статус заказа навигационное свойство
        /// </summary>
        public OrderStatusDTO OrderStatus { get; set; }
        /// <summary>
        /// Продукты в Заказе
        /// </summary>
        public List<OrderProductDTO> orderProducts { get; set; }
        /// <summary>
        /// Пользователь совершивший заказ
        /// </summary>
        public UserDTO user { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime dateOfOrder { get; set; }
        /// <summary>
        /// Описание зкаказа (коментарий к зказу)
        /// </summary>
        public string descriptionOfOrder { get; set; }
        /// <summary>
        /// Итоговоя цена заказа
        /// </summary>
        public decimal totalPrice { get; set; }
        /// <summary>
        /// Валюта оплаты заказа
        /// </summary>
        public Currency currency { get; set; }
        public OrderDTO()
        {
            
        }

    }
}
