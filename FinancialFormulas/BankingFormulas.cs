using System;

namespace srbrettle.FinancialFormulas
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
        public static decimal CalcAnnualPercentageYield(decimal statedAnnualInterestRate, decimal numberOfTimesCompounded)
        {
            return (decimal)Math.Pow((double)(1 + (statedAnnualInterestRate/numberOfTimesCompounded)), (double)numberOfTimesCompounded) - 1;
        }

        /// <summary>
        /// Calculates Balloon Loan Payment from Present Value, Balloon Amount, Rate Per Period and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="balloonAmount">Balloon Amount</param>
        /// <param name="ratePerPeriod">Rate Per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcBalloonLoanPayment(decimal presentValue, decimal balloonAmount, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            decimal pvOfPeriodicPayments = (presentValue - (balloonAmount / (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods)));
            decimal annuityPaymentFactor = (ratePerPeriod / (1 - (decimal)Math.Pow((double)(1 + ratePerPeriod), (double)-numberOfPeriods)));
            return (pvOfPeriodicPayments * annuityPaymentFactor);
        }

        /// <summary>
        /// Calculates Compound Interest from Principal, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="principal">Principal</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcCompoundInterest(decimal principal, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return principal * ((decimal)Math.Pow((double)(1 + ratePerPeriod), (double)numberOfPeriods) - 1);
        }

        /// <summary>
        /// Calculates Continuous Compounding from Principal, Rate and Time
        /// </summary>
        /// <param name="principal">Principal</param>
        /// <param name="rate">Rate</param>
        /// <param name="time">Time</param>
        /// <returns></returns>
        public static decimal CalcContinuousCompounding(decimal principal, decimal rate, decimal time)
        {
            return principal * (decimal)Math.Exp((double)(rate * time));
        }

        /// <summary>
        /// Calculates Debt to Income Ratio from Monthly Debt Payments and Gross Monthly Income
        /// </summary>
        /// <param name="monthlyDebtPayments">Monthly Debt Payments</param>
        /// <param name="grossMonthlyIncome">Gross Monthly Income</param>
        /// <returns></returns>
        public static decimal CalcDebtToIncomeRatio(decimal monthlyDebtPayments, decimal grossMonthlyIncome)
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
        public static decimal CalcBalloonBalanceOfLoan(decimal presentValue, decimal payment, decimal ratePerPayment, decimal numberOfPayments)
        {
            return presentValue * (decimal)Math.Pow((double)(1+ratePerPayment), (double)numberOfPayments)
                - payment * (((decimal)Math.Pow((double)(1+ratePerPayment), (double)numberOfPayments)-1)/ratePerPayment);
        }

        /// <summary>
        /// Calculates Loan Payment from Present Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns></returns>
        public static decimal CalcLoanPayment(decimal presentValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (ratePerPeriod * presentValue)/(1-(decimal)Math.Pow((double)(1+ratePerPeriod), (double)-numberOfPeriods));
        }

        /// <summary>
        /// Calculates Remain Balance on Loan from Present Value, Payment, Rate per Payment and Number of Payments
        /// </summary>
        /// <param name="presentValue">Present Value</param>
        /// <param name="payment">Payment</param>
        /// <param name="ratePerPayment">Rate Per Payment</param>
        /// <param name="numberOfPayments">Number Of Payments</param>
        /// <returns></returns>
        public static decimal CalcRemainingBalanceOnLoan(decimal presentValue, decimal payment, decimal ratePerPayment, decimal numberOfPayments)
        {
            return presentValue * (decimal)Math.Pow((double)(1 + ratePerPayment), (double)numberOfPayments)
                - payment * ((decimal)(Math.Pow((double)(1 + ratePerPayment), (double)numberOfPayments) - 1) / ratePerPayment);
        }

        /// <summary>
        /// Calculates Loan to Deposit Ratio from Loans and Deposits
        /// </summary>
        /// <param name="loans">Loans</param>
        /// <param name="deposits">Deposits</param>
        /// <returns></returns>
        public static decimal CalcLoanToDepositRatio(decimal loans, decimal deposits)
        {
            return loans / deposits;
        }

        /// <summary>
        /// Calculates Loan to Value Ratio from Loan Amount and Value of Collateral
        /// </summary>
        /// <param name="loanAmount">Loan Amount</param>
        /// <param name="ValueOfCollateral">Value of Collateral</param>
        /// <returns></returns>
        public static decimal CalcLoanToValueRatio(decimal loanAmount, decimal ValueOfCollateral)
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
        public static decimal CalcSimpleInterest(decimal principal, decimal rate, decimal time)
        {
            return principal * rate * time;
        }
    }
}
