using srbrettle.FinancialFormulas;
using System;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_CorporateFormulas {

        [Fact]
        public void UnitTest_CalcAssetToSalesRatio()
        {
            var result = CorporateFormulas.CalcAssetToSalesRatio(10000, 4000);
            Assert.Equal(2.5m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAssetTurnoverRatio()
        {
            var result = CorporateFormulas.CalcAssetTurnoverRatio(4000, 10000);
            Assert.Equal(0.4m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcAverageCollectionPeriod()
        {
            var result = CorporateFormulas.CalcAverageCollectionPeriod(1000);
            Assert.Equal(0.37m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcContributionMargin()
        {
            var result = CorporateFormulas.CalcContributionMargin(1000000, 250000);
            Assert.Equal(750000m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcCurrentRatio()
        {
            var result = CorporateFormulas.CalcCurrentRatio(40000, 60000);
            Assert.Equal(0.6666666667m, Math.Round(result, 10, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDaysInInventory()
        {
            var result = CorporateFormulas.CalcDaysInInventory(277);
            Assert.Equal(1.3176895307m, Math.Round(result, 10, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDebtCoverageRatio()
        {
            var result = CorporateFormulas.CalcDebtCoverageRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDebtRatio()
        {
            var result = CorporateFormulas.CalcDebtRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDebtToEquityRatio()
        {
            var result = CorporateFormulas.CalcDebtToEquityRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcDiscountedPaybackPeriod()
        {
            var result = CorporateFormulas.CalcDiscountedPaybackPeriod(4000, 0.04m, 1000);
            Assert.Equal(4.445m, Math.Round(result, 3, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcEquivalentAnnualAnnuity()
        {
            var result = CorporateFormulas.CalcEquivalentAnnualAnnuity(100000, 0.04m, 10);
            Assert.Equal(12329.09m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFreeCashFlowToEquity()
        {
            var result = CorporateFormulas.CalcFreeCashFlowToEquity(100000, 25000, 10000, 5000, 35000);
            Assert.Equal(145000, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcFreeCashFlowToFirm()
        {
            var result = CorporateFormulas.CalcFreeCashFlowToFirm(100000, 0.04m, 10000, 20000, 15000);
            Assert.Equal(71000.00m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcInterestCoverageRatio()
        {
            var result = CorporateFormulas.CalcInterestCoverageRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcInventoryTurnoverRatio()
        {
            var result = CorporateFormulas.CalcInventoryTurnoverRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcNetPresentValue()
        {
            var result = CorporateFormulas.CalcNetPresentValue(100000, new decimal[] { 35000, 55000, 45000, 20000, 5000 }, 0.04m);
            Assert.Equal(45714.99m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcNetProfitMargin()
        {
            var result = CorporateFormulas.CalcNetProfitMargin(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcNetWorkingCapital()
        {
            var result = CorporateFormulas.CalcNetWorkingCapital(1000000, 250000);
            Assert.Equal(750000m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcPaybackPeriod()
        {
            var result = CorporateFormulas.CalcPaybackPeriod(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcQuickRatio()
        {
            var result = CorporateFormulas.CalcQuickRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcReceivablesTurnoverRatio()
        {
            var result = CorporateFormulas.CalcReceivablesTurnoverRatio(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcRetentionRatio()
        {
            var result = CorporateFormulas.CalcRetentionRatio(1000000, 250000);
            Assert.Equal(0.75m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcReturnOnAssets()
        {
            var result = CorporateFormulas.CalcReturnOnAssets(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcReturnOnEquity()
        {
            var result = CorporateFormulas.CalcReturnOnEquity(1000000, 250000);
            Assert.Equal(4.0m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void UnitTest_CalcReturnOnInvestment()
        {
            var result = CorporateFormulas.CalcReturnOnInvestment(180000, 80000);
            Assert.Equal(1.25m, Math.Round(result, 2, MidpointRounding.AwayFromZero));
        }
    }
}