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
        /// Calculates Debt to Income Ratio from Monthly Debt Payments and Gross Monthly Income
        /// </summary>
        /// <param name="monthlyDebtPayments">Monthly Debt Payments</param>
        /// <param name="grossMonthlyIncome">Gross Monthly Income</param>
        /// <returns></returns>
        public static double CalcDebtToIncomeRatio(double monthlyDebtPayments, double grossMonthlyIncome)
        {
            return monthlyDebtPayments / grossMonthlyIncome;
        }

        /// <summary>
        /// Calculates Balloon Balance of Loan from Present Value, Payment, Rate Per Payment and Number Of Payments
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="payment">Payment</param>
        /// <param name="ratePerPayment">Rate Per Payment</param>
        /// <param name="numberOfPayments">Number Of Payments</param>
        /// <returns></returns>
        public static double CalcBalloonBalanceOfLoan(double presentValue, double payment, double ratePerPayment, double numberOfPayments)
        {
            return presentValue*Math.Pow(1+ratePerPayment, numberOfPayments) - payment*((Math.Pow(1+ratePerPayment, numberOfPayments)-1)/ratePerPayment);
        }

        /// <summary>
        /// Calculates Loan Payment from Present Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static double CalcLoanPayment(double presentValue, double ratePerPeriod, double numberOfPeriods)
        {
            return (ratePerPeriod * presentValue)/(1-Math.Pow(1+ratePerPeriod, -numberOfPeriods));
        }

        /// <summary>
        /// Calculates Remain Balance on Loan from Present Value, Payment, Rate per Payment and Number of Payments
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="payment">Payment</param>
        /// <param name="ratePerPayment">Rate Per Payment</param>
        /// <param name="numberOfPayments">Number Of Payments</param>
        /// <returns></returns>
        public static double CalcRemainingBalanceOnLoan(double presentValue, double payment, double ratePerPayment, double numberOfPayments)
        {
            return presentValue * Math.Pow(1 + ratePerPayment, numberOfPayments) - ((Math.Pow(1 + ratePerPayment, numberOfPayments) - 1) / ratePerPayment);
        }

        /// <summary>
        /// Calculates Loan to Deposit Ratio from Loans and Deposits
        /// </summary>
        /// <param name="loans">Loans</param>
        /// <param name="deposits">Deposits</param>
        /// <returns></returns>
        public static double CalcLoanToDepositRatio(double loans, double deposits)
        {
            return loans / deposits;
        }

        /// <summary>
        /// Calculates Loan to Value Ratio from Loan Amount and Value of Collateral
        /// </summary>
        /// <param name="loanAmount">Loan Amount</param>
        /// <param name="ValueOfCollateral">Value of Collateral</param>
        /// <returns></returns>
        public static double CalcLoanToValueRatio(double loanAmount, double ValueOfCollateral)
        {
            return loanAmount / ValueOfCollateral;
        }

        /// <summary>
        /// Calculates Simple Interest from Principal, Rate and Time
        /// </summary>
        /// <param name="principal">Principal</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static double CalcSimpleInterest(double principal, double rate, double time)
        {
            return principal * rate * time;
        }
    }
}
