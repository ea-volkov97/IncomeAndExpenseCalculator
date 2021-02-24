using System.Windows.Media;

namespace IncomeAndExpenseCalculator.Models.Assets
{
    /// <summary>
    /// Представляет абстрактный финансовый актив.
    /// </summary>
    public abstract class FinancialAsset
    {
        /// <summary>
        /// Название финансового актива.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Иконка финансового актива.
        /// </summary>
        public ImageSource Icon { get; private set; }

        /// <summary>
        /// Описание финансового актива.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр финансового актива.
        /// </summary>
        /// <param name="name">Название актива.</param>
        /// <param name="icon">Иконка актива.</param>
        /// <param name="description">Описание актива.</param>
        protected FinancialAsset(string name, ImageSource icon = null, string description = "")
        {
            Name = name;
            Icon = icon;
            Description = description;
        }
    }
}
