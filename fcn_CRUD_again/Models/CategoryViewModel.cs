using DAL.Entities;

namespace fcn_CRUD_again.Models
{
    public class CategoryViewModel
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Язык навигационнлое свойство
        /// </summary>
        public int languageId { get; set; }
        /// <summary>
        /// Название категории
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Описание категории
        /// </summary>
        public string description { get; set; }
    }
}
