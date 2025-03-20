using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    /// <summary>
    /// Значение Характеристики
    /// </summary>
    public class ParameterValueDTO
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
        /// Идентификатор названия характеристики
        /// </summary>
        public int ParameterNameId { get; set; }
        public ParameterNameDTO ParameterName { get; set; }
        /// <summary>
        /// Идентификация языковой версии характеристики.
        /// </summary>
        public int LanguageId { get; set; }
        /// <summary>
        /// Продукт к которому относится данное значение характеристики
        /// </summary>
        public Guid ProductId { get; set; }
    }
}
