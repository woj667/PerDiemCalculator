using System;

namespace PerDiemCalculatorLib
{
    public static class PerDiemProcessor
    {
        public static decimal CalculateTotalAllowance(TimeSpan duration, decimal dayRate)
        {
            decimal output;

            int days = duration.Days;
            int hours = duration.Hours;
            int minutes = duration.Minutes;

            decimal fraction = CalculateFraction(hours, minutes);

            output = days * dayRate + fraction * dayRate;

            return output;
        }

        public static decimal CalculateFraction(int hours, int minutes)
        {
            decimal output;

            if (hours == 0 && minutes == 0)
            {
                output = 0;
            }
            else if ((hours < 8) || (hours == 8 && minutes == 0))
            {
                output = 1 / 3M;
            }
            else if ((hours < 12) || (hours == 12 && minutes == 0))
            {
                output = 1 / 2M;
            }
            else
            {
                output = 1.0M;
            }

            return output;
        }
    }
}