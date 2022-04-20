using System;

namespace PerDiemUI
{
    public static class Validator
    {
        public static bool IsExchangeRateValid(decimal exchangeRate) => exchangeRate > 0;

        public static bool IsTripDurationValid(TimeSpan duration) => duration > TimeSpan.Zero;
    }
}