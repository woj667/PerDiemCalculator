namespace PerDiemCalculatorLib
{
    public class DestinationModel
    {
        /// <summary>
        /// Country Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Country Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country Currency.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Daily allowance in foreign currency.
        /// </summary>
        public decimal PerDiem { get; set; }

        /// <summary>
        /// Maximum hotel price per day.
        /// In case of private stay maximum allowance = 25% of lodging.
        /// </summary>
        public decimal Lodging { get; set; }
    }
}