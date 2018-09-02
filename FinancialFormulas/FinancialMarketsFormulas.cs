using System;

namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Financial-Markets-focused Finance/Accounting equations.
    /// </summary>
    public static class FinancialMarketsFormulas
    {
        /// <summary>
        /// Calculates Rate of Inflation from Initial Consumer Price Index and Ending Consumer Price Index
        /// </summary>
        /// <param name="initialConsumerPriceIndex">Initial Consumer Price Index</param>
        /// <param name="endingConsumerPriceIndex">Ending Consumer Price Index</param>
        /// <returns></returns>
        public static double CalcRateOfInflation(double initialConsumerPriceIndex, double endingConsumerPriceIndex)
        {
            return (endingConsumerPriceIndex-initialConsumerPriceIndex)/initialConsumerPriceIndex;
        }

        /// <summary>
        /// Calculates Real Rate of Return from Nominal Rate and Inflation Rate
        /// </summary>
        /// <param name="nominalRate">Nominal Rate</param>
        /// <param name="inflationRate">Inflation Rate</param>
        /// <returns></returns>
        public static double CalcRealRateOfReturn(double nominalRate, double inflationRate)
        {
            return ((1 + nominalRate) / (1 + inflationRate)) - 1;
        }
    }
}
