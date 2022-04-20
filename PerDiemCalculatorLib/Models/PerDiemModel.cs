using System;

namespace PerDiemCalculatorLib
{
    public class PerDiemModel
    {
        private decimal _exchangeRate = 1;

        /// <summary>
        /// Payment received before business trip.
        /// HOME currency.
        /// </summary>
        public decimal AdvancePayment { get; set; }

        /// <summary>
        /// Business trip allowance calculated base on trip duration.
        /// DESTINATION currency.
        /// </summary>
        public decimal TotalAllowance { get; set; }

        /// <summary>
        /// Business trip allowance calculated base on trip duration.
        /// HOME currency.
        /// </summary>
        public decimal TotalAllowanceExchanged
        {
            get
            {
                return ExchangeRate * TotalAllowance;
            }
        }

        /// <summary>
        /// Amount you have to receive/return.
        /// HOME currency.
        /// </summary>
        public decimal Balance
        {
            get
            {
                return AdvancePayment - TotalAllowanceExchanged;
            }
        }

        /// <summary>
        /// Exchange ratio x:
        /// 1 unit of DESTINATION currency = x units of HOME currency.
        /// </summary>
        public decimal ExchangeRate
        {
            get { return _exchangeRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ExchangeRate", "Value has to be positive!");
                }

                _exchangeRate = value;
            }
        }
    }
}