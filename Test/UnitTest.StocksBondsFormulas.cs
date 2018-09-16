using srbrettle.FinancialFormulas;
using System;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_StocksBondsFormulas {

        [Fact]
        public void UnitTest_CalcBidAskSpread()
        {
            var result = StocksBondsFormulas.CalcBidAskSpread(37.75m, 37.80m);
            Assert.Equal(0.05m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcBondEquivalentYield()
        {
            var result = StocksBondsFormulas.CalcBondEquivalentYield(135, 125, 365);
            Assert.Equal(0.08m, Math.Round(result, 2, MidpointRounding.AwayFromZero));           
        }

        [Fact]
        public void UnitTest_CalcBookValuePerShare()
        {
            var result = StocksBondsFormulas.CalcBookValuePerShare(150000, 3000);
            Assert.Equal(50, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcCapitalAssetPricingModel()
        {
            var result = StocksBondsFormulas.CalcCapitalAssetPricingModel(1, 1.5m, 5);
            Assert.Equal(7.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcCapitalGainsYield()
        {
            var result = StocksBondsFormulas.CalcCapitalGainsYield(435,550);
            Assert.Equal(0.26437m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcCurrentYield()
        {
            var result = StocksBondsFormulas.CalcCurrentYield(100,900);
            Assert.Equal(0.1111m, Math.Round(result, 4, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcDilutedEarningsPerShare()
        {
            var result = StocksBondsFormulas.CalcDilutedEarningsPerShare(1135000, 3000, 450);
            Assert.Equal(328.99m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDividendPayoutRatio()
        {
            var result = StocksBondsFormulas.CalcDividendPayoutRatio(270000, 330000);
            Assert.Equal(0.81818m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDividendYield()
        {
            var result = StocksBondsFormulas.CalcDividendYield(4.35m, 63);
            Assert.Equal(0.06905m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDividendsPerShare()
        {
            var result = StocksBondsFormulas.CalcDividendsPerShare(270000, 3000);
            Assert.Equal(90, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcEarningsPerShare()
        {
            var result = StocksBondsFormulas.CalcEarningsPerShare(330000, 3000);
            Assert.Equal(110, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcEquityMultiplier()
        {
            var result = StocksBondsFormulas.CalcEquityMultiplier(540000, 470000);
            Assert.Equal(1.149m, Math.Round(result, 3, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcEquityMultiplierAlternative()
        {
            var result = StocksBondsFormulas.CalcEquityMultiplier(0.8m);
            Assert.Equal(1.25m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcEstimatedEarnings()
        {
            var result = StocksBondsFormulas.CalcEstimatedEarnings(550000, 430000);
            Assert.Equal(120000m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcEstimatedEarningsWithProfitMargin()
        {
            var result = StocksBondsFormulas.CalcEstimatedEarningsWithProfitMargin(550000, 0.11m);
            Assert.Equal(60500, Math.Round(result, 2, MidpointRounding.AwayFromZero));           
        }

        [Fact]
        public void UnitTest_CalcGeometricMeanReturn()
        {
            var result = StocksBondsFormulas.CalcGeometricMeanReturn(new decimal[] { 0.11m, 0.09m, 0.08m, 0.07m, 0.05m });
            Assert.Equal(0.08m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcHoldingPeriodReturn()
        {
            var result = StocksBondsFormulas.CalcHoldingPeriodReturn(new decimal[] { 0.11m, 0.09m, 0.08m, 0.07m, 0.05m });
            Assert.Equal(0.46807m, Math.Round(result, 5, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcHoldingPeriodReturnAlternative()
        {
            var result = StocksBondsFormulas.CalcHoldingPeriodReturn(0.1m, 10);
            Assert.Equal(1.59374m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcHoldingPeriodReturnAlternative2()
        {
            var result = StocksBondsFormulas.CalcHoldingPeriodReturn(30000, 5000, 25000);
            Assert.Equal(1.4m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcNetAssetValue()
        {
            var result = StocksBondsFormulas.CalcNetAssetValue(6000, 4000, 5000);
            Assert.Equal(0.40m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcPreferredStockValue()
        {
            var result = StocksBondsFormulas.CalcPreferredStockValue(20, 0.04m);
            Assert.Equal(500, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRateOfReturn()
        {
            var result = StocksBondsFormulas.CalcRateOfReturn(4, 40);
            Assert.Equal(0.1m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPriceToBookValueRatio()
        {
            var result = StocksBondsFormulas.CalcPriceToBookValueRatio(500, 400);
            Assert.Equal(1.25m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPriceToEarningsRatio()
        {
            var result = StocksBondsFormulas.CalcPriceToEarningsRatio(500, 400);
            Assert.Equal(1.25m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPriceToSalesRatio()
        {
            var result = StocksBondsFormulas.CalcPriceToSalesRatio(500, 400);
            Assert.Equal(1.25m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRiskPremium()
        {
            var result = StocksBondsFormulas.CalcRiskPremium(500, 200);
            Assert.Equal(300, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcStockPresentValueWithConstantGrowth()
        {
            var result = StocksBondsFormulas.CalcStockPresentValueWithConstantGrowth(20, 0.04m, 0.03m);
            Assert.Equal(2000, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcGrowthRate()
        {
            var result = StocksBondsFormulas.CalcGrowthRate(0.04m, 2);
            Assert.Equal(0.08m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRequiredRateOfReturn()
        {
            var result = StocksBondsFormulas.CalcRequiredRateOfReturn(0.04m, 0.08m);
            Assert.Equal(0.12m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcStockPresentValueWithZeroGrowth()
        {
            var result = StocksBondsFormulas.CalcStockPresentValueWithZeroGrowth(20, 0.04m);
            Assert.Equal(500, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcTaxEquivalentYield()
        {
            var result = StocksBondsFormulas.CalcTaxEquivalentYield(0.04m, 0.3m);
            Assert.Equal(0.05714m, Math.Round(result, 5, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcTotalStockReturnPercentage()
        {
            var result = StocksBondsFormulas.CalcTotalStockReturnPercentage(40, 45, 3);
            Assert.Equal(0.2m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcTotalStockReturnCash()
        {
            var result = StocksBondsFormulas.CalcTotalStockReturnCash(40, 45, 3);
            Assert.Equal(8, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcTotalStockReturnFromYields()
        {
            var result = StocksBondsFormulas.CalcTotalStockReturnFromYields(0.6m, 0.8m);
            Assert.Equal(1.4m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcApproxYieldToMaturity()
        {
            var result = StocksBondsFormulas.CalcApproxYieldToMaturity(100, 1000, 920, 10);
            Assert.Equal(0.1125m, Math.Round(result, 5, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcZeroCouponBondValue()
        {
            var result = StocksBondsFormulas.CalcZeroCouponBondValue(100, 0.06m, 10);
            Assert.Equal(55.84m, Math.Round(result, 2, MidpointRounding.AwayFromZero));            
        }

        [Fact]
        public void UnitTest_CalcZeroCouponBondYield()
        {
            var result = StocksBondsFormulas.CalcZeroCouponBondYield(100, 75, 3);
            Assert.Equal(0.10064m, Math.Round(result, 5, MidpointRounding.AwayFromZero));
        }
    }
}