using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /// <summary>
    /// Название характеристики
    /// </summary>
    public class ParameterName
    {
        /// <summary>
        /// Идентификатор названия характеристики товара
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Навзание характеристики
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Идентификация языковой версии характеристики.
        /// </summary>
        public int LanguageId { get; set; }
    }
}
