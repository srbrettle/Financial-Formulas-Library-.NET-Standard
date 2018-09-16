using srbrettle.FinancialFormulas;
using System;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_GeneralFinanceFormulas {

        [Fact]
        public void UnitTest_CalcFutureValueOfAnnuity()
        {
            var result = GeneralFinanceFormulas.CalcFutureValueOfAnnuity(250, 0.04m, 10);
            Assert.Equal(3001.53m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFutureValueOfAnnuityWithContinuousCompounding()
        {
            var result = GeneralFinanceFormulas.CalcFutureValueOfAnnuityWithContinuousCompounding(250, 0.04m, 10);
            Assert.Equal(3012.84m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcNumberOfPeriodsForFutureValueOfAnnuity()
        {
            var result = GeneralFinanceFormulas.CalcNumberOfPeriodsForFutureValueOfAnnuity(3001.53m, 0.04m, 250);
            Assert.Equal(10, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAnnuityPaymentPresentValue()
        {
            var result = GeneralFinanceFormulas.CalcAnnuityPaymentPresentValue(3001.53m, 0.04m, 10);
            Assert.Equal(370.06m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAnnuityPaymentFutureValue()
        {
            var result = GeneralFinanceFormulas.CalcAnnuityPaymentFutureValue(3001.53m, 0.04m, 10);
            Assert.Equal(250, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcNumberOfPeriodsForPresentValueOfAnnuity()
        {
            var result = GeneralFinanceFormulas.CalcNumberOfPeriodsForPresentValueOfAnnuity(5000, 0.03m, 250);
            Assert.Equal(30.999m, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueOfAnnuity()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueOfAnnuity(250, 0.04m, 10);
            Assert.Equal(2027.72m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAverageCollectionPeriod()
        {
            var result = GeneralFinanceFormulas.CalcAverageCollectionPeriod(5);
            Assert.Equal(73, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueAnnuityFactor()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueAnnuityFactor(0.04m, 10);
            Assert.Equal(8.111m, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueOfAnnuityDue()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueOfAnnuityDue(250, 0.04m, 10);
            Assert.Equal(2108.83m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcFutureValueOfAnnuityDue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcAnnuityDuePaymentUsingPresentValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcAnnuityDuePaymentUsingFutureValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDoublingTime()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDoublingTimeWithContinuousCompounding()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDoublingTimeForSimpleInterest()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcFutureValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcFutureValueWithContinuousCompounding()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcFutureValueFactor()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcFutureValueOfGrowingAnnuity()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcGrowingAnnuityPaymentFromPresentValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcGrowingAnnuityPaymentFromFutureValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPresentValueOfAGrowingAnnuity()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPresentValueOfGrowingPerpetuity()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcNumberOfPeriodsForPresentValueToReachFutureValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPresentValueOfPerpetuity()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPresentValue()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalculatePresentValueWithContinuousCompounding()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPresentValueFactor()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcRuleOf72()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcRateRequiredToDoubleByRuleOf72()
        {

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcWeightedAverage()
        {

        }        
    }
}