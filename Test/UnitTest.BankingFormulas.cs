using System;
using srbrettle.FinancialFormulas;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_BankingFormulas {

		[Fact]	
		public void UnitTest_CalcAnnualPercentageYield()
        {
            var result = BankingFormulas.CalcAnnualPercentageYield(0.04m, 12);
            Assert.Equal(0.0407415m, Math.Round(result, 7, MidpointRounding.AwayFromZero));
		}

        [Fact]
        public void UnitTest_CalcBalloonLoanPayment()
        {
            var result = BankingFormulas.CalcBalloonLoanPayment(10000, 2000, 0.04m, 10);
            Assert.Equal(1066.33m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcCompoundInterest()
        {
            var result = BankingFormulas.CalcCompoundInterest(1000, 0.07m, 10);
            Assert.Equal(967.15m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcContinuousCompounding()
        {
            var result = BankingFormulas.CalcContinuousCompounding(1000, 0.07m, 10);
            Assert.Equal(2013.75m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDebtToIncomeRatio()
        {
            var result = BankingFormulas.CalcDebtToIncomeRatio(250, 1000);
            Assert.Equal(0.25m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcBalloonBalanceOfLoan()
        {
            var result = BankingFormulas.CalcBalloonBalanceOfLoan(100000, 500, 0.04m, 25);
            Assert.Equal(245760.68m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcLoanPayment()
        {
            var result = BankingFormulas.CalcLoanPayment(1000, 0.04m, 10);
            Assert.Equal(123.29m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRemainingBalanceOnLoan()
        {
            var result = BankingFormulas.CalcRemainingBalanceOnLoan(10000, 250, 0.04m, 10);
            Assert.Equal(11800.92m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcLoanToDepositRatio()
        {
            var result = BankingFormulas.CalcLoanToDepositRatio(10000, 4000);
            Assert.Equal(2.5m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcLoanToValueRatio()
        {
            var result = BankingFormulas.CalcLoanToValueRatio(150000, 130000);
            Assert.Equal(1.15m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcSimpleInterest()
        {
            var result = BankingFormulas.CalcSimpleInterest(1000, 0.04m, 10);
            Assert.Equal(400, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcSimpleInterestRate()
        {
            var result = BankingFormulas.CalcSimpleInterestRate(1000, 400, 10);
            Assert.Equal(0.04m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcSimpleInterestPrincipal()
        {
            var result = BankingFormulas.CalcSimpleInterestPrincipal(400, 0.04m, 10);
            Assert.Equal(1000, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcSimpleInterestTime()
        {
            var result = BankingFormulas.CalcSimpleInterestTime(1000, 400, 0.04m);
            Assert.Equal(10, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }
    }
}