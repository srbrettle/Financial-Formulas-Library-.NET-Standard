using srbrettle.FinancialFormulas;
using System;
using System.Collections.Generic;
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

        [Fact]
        public void UnitTest_CalcFutureValueOfAnnuityDue()
        {
            var result = GeneralFinanceFormulas.CalcFutureValueOfAnnuityDue(250, 0.04m, 10);
            Assert.Equal(3121.59m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAnnuityDuePaymentUsingPresentValue()
        {
            var result = GeneralFinanceFormulas.CalcAnnuityDuePaymentUsingPresentValue(2000, 0.04m, 10);
            Assert.Equal(237.10m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAnnuityDuePaymentUsingFutureValue()
        {
            var result = GeneralFinanceFormulas.CalcAnnuityDuePaymentUsingFutureValue(2000, 0.04m, 10);
            Assert.Equal(160.17m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDoublingTime()
        {
            var result = GeneralFinanceFormulas.CalcDoublingTime(0.04m);
            Assert.Equal(17.673m, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDoublingTimeWithContinuousCompounding()
        {
            var result = GeneralFinanceFormulas.CalcDoublingTimeWithContinuousCompounding(0.04m);
            Assert.Equal(17.329m, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDoublingTimeForSimpleInterest()
        {
            var result = GeneralFinanceFormulas.CalcDoublingTimeForSimpleInterest(0.04m);
            Assert.Equal(25, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFutureValue()
        {
            var result = GeneralFinanceFormulas.CalcFutureValue(250, 0.04m, 10);
            Assert.Equal(370.06m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFutureValueWithContinuousCompounding()
        {            
            var result = GeneralFinanceFormulas.CalcFutureValueWithContinuousCompounding(250, 0.04m, 10);
            Assert.Equal(372.96m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFutureValueFactor()
        {
            var result = GeneralFinanceFormulas.CalcFutureValueFactor(0.04m, 10);
            Assert.Equal(1.4802m, Math.Round(result, 4, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFutureValueOfGrowingAnnuity()
        {
            var result = GeneralFinanceFormulas.CalcFutureValueOfGrowingAnnuity(250, 0.04m, 0.03m, 10);
            Assert.Equal(3408.20m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcGrowingAnnuityPaymentFromPresentValue()
        {
            var result = GeneralFinanceFormulas.CalcGrowingAnnuityPaymentFromPresentValue(250, 0.04m, 0.03m, 10);
            Assert.Equal(27.14m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcGrowingAnnuityPaymentFromFutureValue()
        {
            var result = GeneralFinanceFormulas.CalcGrowingAnnuityPaymentFromFutureValue(250, 0.04m, 0.03m, 10);
            Assert.Equal(18.34m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueOfGrowingAnnuity()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueOfGrowingAnnuity(250, 0.04m, 0.03m, 10);
            Assert.Equal(2302.46m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueOfGrowingPerpetuity()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueOfGrowingPerpetuity(250, 0.04m, 0.03m);
            Assert.Equal(25000.00m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcNumberOfPeriodsForPresentValueToReachFutureValue()
        {
            var result = GeneralFinanceFormulas.CalcNumberOfPeriodsForPresentValueToReachFutureValue(3000, 2000, 0.07m);
            Assert.Equal(5.9928m, Math.Round(result, 4, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueOfPerpetuity()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueOfPerpetuity(10, 0.05m);
            Assert.Equal(200m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValue()
        {
            var result = GeneralFinanceFormulas.CalcPresentValue(250, 0.04m, 10);
            Assert.Equal(168.89m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalculatePresentValueWithContinuousCompounding()
        {
            var result = GeneralFinanceFormulas.CalculatePresentValueWithContinuousCompounding(250, 0.04m, 10);
            Assert.Equal(167.58m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPresentValueFactor()
        {
            var result = GeneralFinanceFormulas.CalcPresentValueFactor(0.04m, 10);
            Assert.Equal(0.67556m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRuleOf72()
        {
            var result = GeneralFinanceFormulas.CalcRuleOf72(0.04m);
            Assert.Equal(18, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRateRequiredToDoubleByRuleOf72()
        {
            var result = GeneralFinanceFormulas.CalcRateRequiredToDoubleByRuleOf72(18m);
            Assert.Equal(0.04m, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcWeightedAverage()
        {
            var weightedReturns = new List<KeyValuePair<decimal, decimal>> {
                new KeyValuePair<decimal, decimal>(0.06m, 0.25m),
                new KeyValuePair<decimal, decimal>(0.05m, 0.25m),
                new KeyValuePair<decimal, decimal>(0.02m, 0.5m),
            };
            var result = GeneralFinanceFormulas.CalcWeightedAverage(weightedReturns); 
            Assert.Equal(0.03750m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }        
    }
}