using srbrettle.FinancialFormulas;
using System;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_BankingFormulas {

		[Fact]	
		public void UnitTest_CalcAnnualPercentageYield()
        {
            var result = BankingFormulas.CalcAnnualPercentageYield(0.04m , 12);
            Assert.Equal(0.0407415m, Math.Round(result, 7, MidpointRounding.AwayFromZero));
            //TODO: Test how much impact approximations are having on results (double -> decimal?)
		}

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcBalloonLoanPayment()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcCompoundInterest()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcContinuousCompounding()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDebtToIncomeRatio()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcBalloonBalanceOfLoan()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcLoanPayment()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcRemainingBalanceOnLoan()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcLoanToDepositRatio()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcLoanToValueRatio()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcSimpleInterest()
        {

        }
    }
}