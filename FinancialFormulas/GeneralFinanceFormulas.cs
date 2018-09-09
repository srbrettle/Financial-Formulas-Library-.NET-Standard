using System;

namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving General-Finance-focused Finance/Accounting equations.
    /// </summary>
    public static class GeneralFinanceFormulas
    {
        /// <summary>
        /// Calculates Future Value of Annuity from Periodic Payment, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="periodicPayment">Periodic Payment</param>
        /// <param name="ratePerPriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcFutureValueOfAnnuity(decimal periodicPayment, decimal ratePerPriod, decimal numberOfPeriods)
        {
            return periodicPayment * (((decimal)Math.Pow((double)(1 + ratePerPriod), (double)numberOfPeriods) - 1) / ratePerPriod);
        }

        /// <summary>
        /// Calculates Future Value of Annuity with Continuous Compounding
        /// </summary>
        /// <param name="cashFlow">Cash Flow</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static decimal CalcFutureValueOfAnnuityWithContinuousCompounding(decimal cashFlow, decimal rate, decimal time)
        {
            return cashFlow * ((decimal)(Math.Exp((double)(rate * time)) - 1) / ((decimal)Math.Exp((double)rate) - 1));
        }

        /// <summary>
        /// Calculates Number of Periods for Future Value of Annuity from Future Value of Annuity, Rate and Payment
        /// </summary>
        /// <param name="futureValueOfAnnuity">Future Value of Annuity</param>
        /// <param name="rate">Rate</param>
        /// <param name="payment">Payment</param>
        /// <returns></returns>
        public static decimal CalcNumberOfPeriodsForFutureValueOfAnnuity(decimal futureValueOfAnnuity, decimal rate, decimal payment)
        {
            return (decimal) Math.Log(1 + (double)((futureValueOfAnnuity * rate) / payment)) / (decimal) Math.Log((double)(1 + rate));
        }

        /// <summary>
        /// Calculates Present Value Annuity Payment from Present Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcAnnuityPaymentPresentValue(decimal presentValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (ratePerPeriod * presentValue) / (1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-numberOfPeriods));
        }

        /// <summary>
        /// Calculates Future Value Annuity Payment from Future Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="futureValue">Future Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcAnnuityPaymentFutureValue(decimal futureValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (ratePerPeriod * futureValue) / ((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - 1);
        }

        /// <summary>
        /// Calculates Number of Periods for Present Value of Annuity from Present Value of Annuity, Rate and Payment
        /// </summary>
        /// <param name="presentValueOfAnnuity">Present Value of Annuity</param>
        /// <param name="rate">Rate</param>
        /// <param name="payment">Payment</param>
        /// <returns></returns>
        public static decimal CalcNumberOfPeriodsForPresentValueOfAnnuity(decimal presentValueOfAnnuity, decimal rate, decimal payment)
        {
            return (decimal)Math.Log(Math.Pow(1 - (double)((presentValueOfAnnuity * rate) / payment), -1)) / (decimal)Math.Log((double)(1 + rate));
        }
    }
}
