using System;
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
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Future Value of Annuity</returns>
        public static decimal CalcFutureValueOfAnnuity(decimal periodicPayment, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return periodicPayment * (((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - 1) / ratePerPeriod);
        }

        /// <summary>
        /// Calculates Future Value of Annuity with Continuous Compounding from Cash Flow, Rate and Time
        /// </summary>
        /// <param name="cashFlow">Cash Flow</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns>Decimal value for Future Value of Annuity with Continuous Compounding</returns>
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
        /// <returns>Decimal value for Number of Periods for Future Value of Annuity</returns>
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
        /// <returns>Decimal value for Present Value Annuity Payment</returns>
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
        /// <returns>Decimal value for Future Value Annuity Payment</returns>
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
        /// <returns>Decimal value for Number of Periods for Present Value of Annuity</returns>
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
        /// <returns>Decimal value for Present Value of Annuity</returns>
        public static decimal CalcPresentValueOfAnnuity(decimal periodicPayment, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return periodicPayment * ((1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-numberOfPeriods)) / ratePerPeriod);
        }

        /// <summary>
        /// Calculates Average Collection Period from Receivables Turnover
        /// </summary>
        /// <param name="receivableTurnover">Receivables Turnover</param>
        /// <returns>Decimal value for Average Collection Period</returns>
        public static decimal CalcAverageCollectionPeriod(decimal receivableTurnover)
        {
            return 365 / receivableTurnover;
        }

        /// <summary>
        /// Calculates Present Value Annuity Factor from Rate per Period and Number of Periods
        /// </summary>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Present Value Annuity Factor</returns>
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
        /// <returns>Decimal value for Present Value of Annuity Due</returns>
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
        /// <returns>Decimal value for Future Value of Annuity Due</returns>
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
        /// <returns>Decimal value for Annuity Due Payment using Present Value</returns>
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
        /// <returns>Decimal value for Annuity Due Payment using Future Value</returns>
        public static decimal CalcAnnuityDuePaymentUsingFutureValue(decimal futureValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return futureValue * (ratePerPeriod / ((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - 1)) * (1 / (1 + ratePerPeriod));
        }

        /// <summary>
        /// Calculates Doubling Time from Rate of Return
        /// </summary>
        /// <param name="rateOfReturn">Rate of Return</param>
        /// <returns>Decimal value for Doubling Time</returns>
        public static decimal CalcDoublingTime(decimal rateOfReturn)
        {
            return (decimal)Math.Log(2) / (decimal)Math.Log((double)(1 + rateOfReturn));
        }

        /// <summary>
        /// Calculates Doubling Time with Continuous Compounding from Rate
        /// </summary>
        /// <param name="rate">Rate</param>
        /// <returns>Decimal value for Doubling Time with Continuous Compounding</returns>
        public static decimal CalcDoublingTimeWithContinuousCompounding(decimal rate)
        {
            return (decimal)Math.Log(2) / rate;
        }

        /// <summary>
        /// Calculates Doubling Time For Simple Interest
        /// </summary>
        /// <param name="rate">Rate</param>
        /// <returns>Decimal value for Doubling Time</returns>
        public static decimal CalcDoublingTimeForSimpleInterest(decimal rate)
        {
            return 1 / rate;
        }

        /// <summary>
        /// Calculates Future Value from Initial Cash Flow, Rate of Return and Number of Periods
        /// </summary>
        /// <param name="initialCashFlow">Initial Cash Flow</param>
        /// <param name="rateOfReturn">Rate of Return</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Future Value</returns>
        public static decimal CalcFutureValue(decimal initialCashFlow, decimal rateOfReturn, decimal numberOfPeriods)
        {
            return initialCashFlow * (decimal)Math.Pow((double)(1 + rateOfReturn), (double)numberOfPeriods);
        }

        /// <summary>
        /// Calculates Future Value with Continuous Compounding from Present Value, Rate and Time
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns>Decimal value for Future Value with Continuous Compounding</returns>
        public static decimal CalcFutureValueWithContinuousCompounding(decimal presentValue, decimal rate, decimal time)
        {
            return presentValue * (decimal)Math.Exp((double)(rate * time));
        }

        /// <summary>
        /// Calculates Future Value Factor from Rate per Period and Number of Periods
        /// </summary>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Future Value Factor</returns>
        public static decimal CalcFutureValueFactor(decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods);
        }

        /// <summary>
        /// Calculates Future Value of Growing Annuity from First Payment, Rate per Period, Growth Rate and Number of Periods
        /// </summary>
        /// <param name="firstPayment">First Payment</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Future Value of Growing Annuity</returns>
        public static decimal CalcFutureValueOfGrowingAnnuity(decimal firstPayment, decimal ratePerPeriod, decimal growthRate, decimal numberOfPeriods)
        {
            decimal numerator = (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - (decimal)Math.Pow((double)(1 + growthRate), (double)numberOfPeriods);
            decimal denominator = ratePerPeriod - growthRate;
            return firstPayment * (numerator / denominator);
        }

        /// <summary>
        /// Calculates Growing Annuity Payment from Present Value from Present value, Rate per Period, Growth Rate and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Growing Annuity Payment</returns>
        public static decimal CalcGrowingAnnuityPaymentFromPresentValue(decimal presentValue, decimal ratePerPeriod, decimal growthRate, decimal numberOfPeriods)
        {
            return presentValue * ((ratePerPeriod - growthRate) / (1 - (decimal)Math.Pow((double)((1 + growthRate) / (1 + ratePerPeriod)), (double)numberOfPeriods)));
        }

        /// <summary>
        /// Calculates Growing Annuity Payment from Future Value from Future Value, Rate per Period, Growth Rate and Number of Periods
        /// </summary>
        /// <param name="futureValue">Future Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Growing Annuity Payment</returns>
        public static decimal CalcGrowingAnnuityPaymentFromFutureValue(decimal futureValue, decimal ratePerPeriod, decimal growthRate, decimal numberOfPeriods)
        {
            return futureValue * ((ratePerPeriod - growthRate) / ((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - (decimal)Math.Pow((double)(1 + growthRate), (double)numberOfPeriods)));
        }

        /// <summary>
        /// Calculates Present Value of Growing Annuity from First Payment, Rate per Period, Growth Rate and Number of Periods
        /// </summary>
        /// <param name="firstPayment">First Payment</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Present Value of Growing Annuity</returns>
        public static decimal CalcPresentValueOfGrowingAnnuity(decimal firstPayment, decimal ratePerPeriod, decimal growthRate, decimal numberOfPeriods)
        {
            return (firstPayment / (ratePerPeriod - growthRate)) * (1 - (decimal)(Math.Pow((double)((1 + growthRate) / (1 + ratePerPeriod)), (double)numberOfPeriods)));
        }

        /// <summary>
        /// Calculates Present Value of Growing Perpetuity from Dividend or Coupon at First Period, Discount Rate and Growth Rate
        /// </summary>
        /// <param name="dividendOrCouponAtFirstPeriod">Dividend or Coupon at First Period</param>
        /// <param name="discountRate">Discount Rate</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <returns>Decimal value for Present Value of Growing Perpetuity</returns>
        public static decimal CalcPresentValueOfGrowingPerpetuity(decimal dividendOrCouponAtFirstPeriod, decimal discountRate, decimal growthRate)
        {
            return dividendOrCouponAtFirstPeriod / (discountRate - growthRate);
        }
        /// <summary>
        /// Calculates Number of Periods for Present Value to reach Future Value from Future Value, Present Value and Rate per Period
        /// </summary>
        /// <param name="futureValue">Future Value</param>
        /// <param name="presentValue">Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <returns>Decimal value for Number of Periods for Present Value to reach Future Value</returns>
        public static decimal CalcNumberOfPeriodsForPresentValueToReachFutureValue(decimal futureValue, decimal presentValue, decimal ratePerPeriod)
        {
            return (decimal)Math.Log((double)(futureValue / presentValue)) / (decimal)Math.Log((double)(1 + ratePerPeriod));
        }

        /// <summary>
        /// Calculates Present Value of Perpetuity from Dividend or Coupon per Period and Discount Rate
        /// </summary>
        /// <param name="dividendOrCouponPerPeriod">Dividend or Coupon per Period</param>
        /// <param name="discountRate">Discount Rate</param>
        /// <returns>Decimal value for Present Value of Perpetuity</returns>
        public static decimal CalcPresentValueOfPerpetuity(decimal dividendOrCouponPerPeriod, decimal discountRate)
        {
            return dividendOrCouponPerPeriod / discountRate;
        }

        /// <summary>
        /// Calculate Present Value from Cash Flow After First Period, Rate of Return and Number of Periods
        /// </summary>
        /// <param name="cashFlowAfterFirstPeriod">Cash Flow After First Period</param>
        /// <param name="rateOfReturn">Rate of return</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Present Value</returns>
        public static decimal CalcPresentValue(decimal cashFlowAfterFirstPeriod, decimal rateOfReturn, decimal numberOfPeriods)
        {
            return cashFlowAfterFirstPeriod / (decimal)Math.Pow((double)(1 + rateOfReturn), (double)numberOfPeriods);
        }

        /// <summary>
        /// Calculates Present Value with Continuous Compounding from Cash Flow, Rate and Time
        /// </summary>
        /// <param name="cashFlow">Cash Flow</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns>Decimal value for Present Value with Continuous Compounding</returns>
        public static decimal CalculatePresentValueWithContinuousCompounding(decimal cashFlow, decimal rate, decimal time)
        {
            return cashFlow / (decimal)Math.Exp((double)(rate * time));
        }

        /// <summary>
        /// Calculates Present Value Factor from Rate of Return and Number of Periods
        /// </summary>
        /// <param name="rateOfReturn">Rate of Return</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Present Value Factor</returns>
        public static decimal CalcPresentValueFactor(decimal rateOfReturn, decimal numberOfPeriods)
        {
            return 1 / (decimal)Math.Pow((double)(1 + rateOfReturn), (double)numberOfPeriods);
        }

        /// <summary>
        /// Calculates Rule of 72 from Rate Expressed as a Whole Number
        /// </summary>
        /// <param name="rate">Rate</param>
        /// <returns>Decimal value for Rule of 72</returns>
        public static decimal CalcRuleOf72(decimal rate)
        {
            return 72 / (rate * 100);
        }

        /// <summary>
        /// Calculates the Rate Required to Double from Length of Time
        /// </summary>
        /// <param name="lengthOfTime">Length of Time</param>
        /// <returns>Decimal value for Rate Required to Double</returns>
        public static decimal CalcRateRequiredToDoubleByRuleOf72(decimal lengthOfTime)
        {
            return (72 / lengthOfTime) / 100;
        }

        /// <summary>
        /// Calculates Weighted Average from Relative Weights and Values
        /// </summary>
        /// <param name="relativeWeightsAndValues">Relative Weights and Values</param>
        /// <returns>Decimal value for Weighted Average</returns>
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
