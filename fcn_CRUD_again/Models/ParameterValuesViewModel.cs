using DAL.Entities;

namespace fcn_CRUD_again.Models
{
    public class ParameterValuesViewModel
    {
        /// <summary>
        /// Идентификатор значения характеристики товара
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Значение характеристики к примеру: красный,М, шерсть.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        ///  названия характеристики
        /// </summary>
        public string ParameterName { get; set; }
        public int ParameterNameId { get; set; }
    }
}
