using System;

namespace PerDiemCalculatorLib
{
    ///
    public class BusinessTripModel
    {
        /// <summary>
        /// Business trip start time.
        /// </summary>
        public DateTime Finish { get; set; }

        /// <summary>
        /// Business trip finish time.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Duration of the business trip.
        /// If calculated duration < 0 returns 0.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                TimeSpan duration = Finish - Start;

                return duration > TimeSpan.Zero ? duration : TimeSpan.Zero;
            }
        }
    }
}