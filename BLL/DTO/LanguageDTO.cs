using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class LanguageDTO
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
