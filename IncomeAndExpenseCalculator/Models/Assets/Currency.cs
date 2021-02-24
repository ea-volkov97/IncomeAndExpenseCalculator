using System.Windows.Media;

namespace IncomeAndExpenseCalculator.Models.Assets
{
    /// <summary>
    /// Представляет валюту.
    /// </summary>
    public class Currency : FinancialAsset
    {
        /// <summary>
        /// Обозначение валюты.
        /// </summary>
        public char Symbol { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр валюты.
        /// </summary>
        /// <param name="name">Название валюты.</param>
        /// <param name="symbol">Обозначение валюты.</param>
        public Currency(string name, char symbol = ' ', ImageSource icon = null, string description = "") : base(name, icon, description)
        {
            Symbol = symbol;
        }
    }
}
