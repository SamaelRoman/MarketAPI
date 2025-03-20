using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class UserDTO
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public Guid id { get; set; }
        public string login { get; set; }
        /// <summary>
        /// Пароль пользователя ( естественно захешировананый и с солью )
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// Почта телефона зказчика
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Номер телефона зказчика
        /// </summary>
        public string phoneNumber { get; set; }
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
    }
}
