using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Banking-focused Finance/Accounting equations.
    /// </summary>
    public static class BankingFormulas
    {
        /// <summary>
        /// Calculates Annual Percentage Yield from Stated Annual Interest Rate and Number of Times Compounded
        /// </summary>
        /// <param name="statedAnnualInterestRate">Stated Annual Interest Rate</param>
        /// <param name="numberOfTimesCompounded">Number of Times Compounded</param>
        /// <returns></returns>
        public static double CalcAnnualPercentageYield(double statedAnnualInterestRate, double numberOfTimesCompounded)
        {
            return Math.Pow(1 + (statedAnnualInterestRate/numberOfTimesCompounded), numberOfTimesCompounded) - 1;
        }

        /// <summary>
        /// Calculates Balloon Loan Payment from Present Value, Balloon Amount, Rate Per Period and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="balloonAmount">Balloon Amount</param>
        /// <param name="ratePerPeriod">Rate Per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static double CalcBalloonLoanPayment(double presentValue, double balloonAmount, double ratePerPeriod, double numberOfPeriods)
        {
            double pvOfPeriodicPayments = (presentValue - (balloonAmount / Math.Pow(1 + ratePerPeriod, numberOfPeriods)));
            double annuityPaymentFactor = (ratePerPeriod / (1 - Math.Pow(1 + ratePerPeriod, -numberOfPeriods)));
            return (pvOfPeriodicPayments * annuityPaymentFactor);
        }

        /// <summary>
        /// Calculates Compound Interest from Principal, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="principal">Principal</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static double CalcCompoundInterest(double principal, double ratePerPeriod, double numberOfPeriods)
        {
            return principal * (Math.Pow(1 + ratePerPeriod, numberOfPeriods) - 1);
        }

        /// <summary>
        /// Calculates Continuous Compounding from Principal, Rate and Time
        /// </summary>
        /// <param name="principal">Principal</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static double CalcContinuousCompounding(double principal, double rate, double time)
        {
            return principal * Math.Exp(rate * time);
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="monthlyDebtPayments"></param>
        /// <param name="grossMonthlyIncome"></param>
        /// <returns></returns>
        public static double CalcDebtToIncomeRatio(double monthlyDebtPayments, double grossMonthlyIncome)
        {
            return monthlyDebtPayments / grossMonthlyIncome;
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="payment"></param>
        /// <param name="ratePerPayment"></param>
        /// <param name="numberOfPayments"></param>
        /// <returns></returns>
        public static double CalcBalloonBalanceOfLoan(double presentValue, double payment, double ratePerPayment, double numberOfPayments)
        {
            return presentValue*Math.Pow(1+ratePerPayment, numberOfPayments) - payment*((Math.Pow(1+ratePerPayment, numberOfPayments)-1)/ratePerPayment);
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="ratePerPeriod"></param>
        /// <param name="numberOfPeriods"></param>
        /// <returns></returns>
        public static double CalcLoanPayment(double presentValue, double ratePerPeriod, double numberOfPeriods)
        {
            return (ratePerPeriod * presentValue)/(1-Math.Pow(1+ratePerPeriod, -numberOfPeriods));
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="presentValue"></param>
        /// <param name="payment"></param>
        /// <param name="ratePerPayment"></param>
        /// <param name="numberOfPayments"></param>
        /// <returns></returns>
        public static double CalcRemainingBalanceOnLoan(double presentValue, double payment, double ratePerPayment, double numberOfPayments)
        {
            return presentValue * Math.Pow(1 + ratePerPayment, numberOfPayments) - ((Math.Pow(1 + ratePerPayment, numberOfPayments) - 1) / ratePerPayment);
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="loans"></param>
        /// <param name="deposits"></param>
        /// <returns></returns>
        public static double CalcLoanToDepositRatio(double loans, double deposits)
        {
            return loans / deposits;
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="loanAmount"></param>
        /// <param name="ValueOfCollateral"></param>
        /// <returns></returns>
        public static double CalcLoanToValueRatio(double loanAmount, double ValueOfCollateral)
        {
            return loanAmount / ValueOfCollateral;
        }

        /// <summary>
        /// Calculates 
        /// </summary>
        /// <param name="principal"></param>
        /// <param name="rate"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double CalcSimpleInterest(double principal, double rate, double time)
        {
            return principal * rate * time;
        }
    }
}
