using DAL.Entities;

namespace fcn_CRUD_again.Models
{
    public class LanguageViewModel
    {
        /// <summary>
        /// Код языка (идентификатор)
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название языка
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Сокращенное название языка
        /// </summary>
        public string shortName { get; set; }
    }
}
