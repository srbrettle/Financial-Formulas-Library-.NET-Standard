using System;
using System.Collections;
using System.Collections.Generic;

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

        /// <summary>
        /// Calculates Present Value of Annuity from Periodic Payment, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="periodicPayment">Calculates Present Value of Annuity</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcPresentValueOfAnnuity(decimal periodicPayment, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return periodicPayment * ((1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-numberOfPeriods)) / ratePerPeriod);
        }

        /// <summary>
        /// Calculates Average Collection Period from Receivables Turnover
        /// </summary>
        /// <param name="receivableTurnover">Receivables Turnover</param>
        /// <returns></returns>
        public static decimal CalcAverageCollectionPeriod(decimal receivableTurnover)
        {
            return 365 / receivableTurnover;
        }

        /// <summary>
        /// Calculates Present Value Annuity Factor from Rate per Period and Number of Periods
        /// </summary>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcPresentValueAnnuityFactor(decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-numberOfPeriods)) / ratePerPeriod;
        }

        /// <summary>
        /// Calculates Present Value of Annuity Due from Periodic Payment, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="periodicPayment">Periodic Payment</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcPresentValueOfAnnuityDue(decimal periodicPayment, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return periodicPayment + periodicPayment * ((1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-(numberOfPeriods - 1))) / ratePerPeriod);
        }

        /// <summary>
        /// Calculates Future Value of Annuity Due from Periodic Payment, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="periodicPayment">Periodic Payment</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcFutureValueOfAnnuityDue(decimal periodicPayment, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (1 + ratePerPeriod) * periodicPayment * (((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - 1) / ratePerPeriod);
        }

        /// <summary>
        /// Calculates Annuity Due Payment using Present Value from Present Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">number of Periods</param>
        /// <returns></returns>
        public static decimal CalcAnnuityDuePaymentUsingPresentValue(decimal presentValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return presentValue * (ratePerPeriod / (1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-numberOfPeriods))) * (1 / (1 + ratePerPeriod));
        }

        /// <summary>
        /// Calculates Annuity Due Payment using Future Value from Future Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="futureValue">Future Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">number of Periods</param>
        /// <returns></returns>
        public static decimal CalcAnnuityDuePaymentUsingFutureValue(decimal futureValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return futureValue * (ratePerPeriod / ((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - 1)) * (1 / (1 + ratePerPeriod));
        }

        /// <summary>
        /// Calculates Present Value Factor from Rate of Return and Number of Periods
        /// </summary>
        /// <param name="rateOfReturn">Rate of Return</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcPresentValueFactor(decimal rateOfReturn, decimal numberOfPeriods)
        {
            return 1 / (decimal)Math.Pow((double)(1 + rateOfReturn), (double)numberOfPeriods);
        }

        /// <summary>
        /// Calculates Rule of 72 from Rate Expressed as a Whole Number
        /// </summary>
        /// <param name="rate">Rate</param>
        /// <returns></returns>
        public static decimal CalcRuleOf72(decimal rate)
        {
            return 72 / (rate * 100);
        }

        /// <summary>
        /// Calculates the Rate Required to Double from Length of Time
        /// </summary>
        /// <param name="lengthOfTime">Length of Time</param>
        /// <returns></returns>
        public static decimal CalcRateRequiredToDouble(decimal lengthOfTime)
        {
            return (72 / lengthOfTime) / 100;
        }

        /// <summary>
        /// Calculates Weighted Average from Relative Weights and Values
        /// </summary>
        /// <param name="relativeWeightsAndValues">Relative Weights and Values</param>
        /// <returns></returns>
        public static decimal CalcWeightedAverage(ICollection<KeyValuePair<decimal, decimal>> relativeWeightsAndValues)
        {           
            decimal sumTotal = 0;
            foreach (var item in relativeWeightsAndValues)
            {
                sumTotal += (item.Key * item.Value);
            }
            return sumTotal;
        }
    }
}
