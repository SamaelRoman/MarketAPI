namespace fcn_CRUD_again.Models
{
    public class CurrencyViewModel
    {
        /// <summary>
        /// Идентификатор валюты
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название валюты
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///  Сокращенное (краткое) название валюты
        /// </summary>
        public string shortName { get; set; }
        /// <summary>
        /// Символ валюты (к примеру $)
        /// </summary>
        public char currencySymbol { get; set; }
        /// <summary>
        /// Показатель основной валюты сервиса от нее происходят все пересчеты цен на другие валюты.
        /// </summary>
        public bool mainCurrency { get; set; }
        /// <summary>
        /// Множитель валюты (курс). В случае "mainCurrency == true" будерт равнятся единице
        /// </summary>
        public decimal curencyRate { get; set; }
    }
}
