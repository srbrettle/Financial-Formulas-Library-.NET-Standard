using srbrettle.FinancialFormulas;
using System;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_FinancialFormulas
    {        
        [Fact]
        public void AssetTurnover_ValidInput_ReturnsCorrect()
        {            
            decimal result = FinancialFormulas.CalcAssetTurnover(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void AverageCollectionPeriod_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcAverageCollectionPeriod(500, 200);
            Assert.Equal(912.5m, Math.Round(result, 24, MidpointRounding.AwayFromZero));
        }

        [Fact]
        public void CashConversionCycle_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcCashConversionCycle(500, 200, 100);
            Assert.Equal(600.0m, result);
        }

        [Fact]
        public void InventoryConversionPeriod_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcInventoryConversionPeriod(365);
            Assert.Equal(1.0m, result);
        }

        [Fact]
        public void InventoryConversionRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcInventoryConversionRatio(500, 200);
            Assert.Equal(1.25m, result);
        }

        [Fact]
        public void InventoryTurnover_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcInventoryTurnover(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void PayablesConversionPeriod_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcPayablesConversionPeriod(500, 200);
            Assert.Equal(912.5m, result);
        }

        [Fact]
        public void ReceivablesConversionPeriod_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReceivablesConversionPeriod(500, 200);
            Assert.Equal(912.5m, result);
        }

        [Fact]
        public void ReceivablesTurnoverRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReceivablesTurnoverRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void Assets_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcAssets(300, 200);
            Assert.Equal(500.0m, result);
        }

        [Fact]
        public void Ebit_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcEbit(500, 200);
            Assert.Equal(300.0m, result);
        }

        [Fact]
        public void Equity_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcEquity(300, 200);
            Assert.Equal(100.0m, result);
        }

        [Fact]
        public void GrossProfit_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcGrossProfit(500, 200);
            Assert.Equal(300.0m, result);
        }

        [Fact]
        public void Liabilities_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcLiabilities(500, 200);
            Assert.Equal(300.0m, result);
        }

        [Fact]
        public void NetProfit_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcNetProfit(500, 200, 100, 100);
            Assert.Equal(100.0m, result);
        }

        [Fact]
        public void OperatingProfit_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcOperatingProfit(500, 200);
            Assert.Equal(300.0m, result);
        }

        [Fact]
        public void SalesRevenue_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcSalesRevenue(500, 200);
            Assert.Equal(300.0m, result);
        }

        [Fact]
        public void DebtEquityRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDebtEquityRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void DebtRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDebtRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void DebtServiceCoverageRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDebtServiceCoverageRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void LongTermDebtEquityRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcLongTermDebtEquityRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void BookValue_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcBookValue(500, 200);
            Assert.Equal(300.0m, result);
        }

        [Fact]
        public void DecliningBalance_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDecliningBalance(0.5m, 200);
            Assert.Equal(100.0m, result);
        }

        [Fact]
        public void UnitsOfProduction_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcUnitsOfProduction(500, 200, 100, 150);
            Assert.Equal(450.0m, result);
        }

        [Fact]
        public void StraightLineMethod_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcStraightLineMethod(500, 200, 10);
            Assert.Equal(30.0m, result);
        }

        [Fact]
        public void CashRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcCashRatio(500, 200, 100);
            Assert.Equal(7.0m, result);
        }

        [Fact]
        public void CurrentRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcCurrentRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void OperatingCashFlowRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcOperatingCashFlowRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void QuickRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcQuickRatio(500, 200, 100);
            Assert.Equal(3.0m, result);
        }

        [Fact]
        public void DividendCover_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDividendCover(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void DividendsPerShare_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDividendsPerShare(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void DividendYield_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcDividendYield(5, 200);
            Assert.Equal(0.025m, result);
        }

        [Fact]
        public void EarningsPerShare_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcEarningsPerShare(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void PayoutRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcPayoutRatio(500, 10000);
            Assert.Equal(0.05m, result);
        }

        [Fact]
        public void PegRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcPegRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void PriceSalesRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcPriceSalesRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void EfficiencyRatio_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcEfficiencyRatio(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void GrossProfitMargin_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcGrossProfitMargin(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void OperatingMargin_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcOperatingMargin(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void ProfitMargin_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcProfitMargin(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void ReturnOnAssets_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReturnOnAssets(500, 200);
            Assert.Equal(2.50m, result);
        }

        [Fact]
        public void ReturnOnCapital_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReturnOnCapital(500, 0.2m, 100);
            Assert.Equal(4.0m, result);
        }

        [Fact]
        public void ReturnOnEquity_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReturnOnEquity(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void ReturnOnNetAssets_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReturnOnNetAssets(500, 200, 50);
            Assert.Equal(2.0m, result);
        }

        [Fact]
        public void RiskAdjustedReturnOnCapital_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcRiskAdjustedReturnOnCapital(500, 200);
            Assert.Equal(2.5m, result);
        }

        [Fact]
        public void ReturnOnInvestment_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcReturnOnInvestment(500, 200);
            Assert.Equal(1.5m, result);
        }

        [Fact]
        public void Ebitda_ValidInput_ReturnsCorrect()
        {
            decimal result = FinancialFormulas.CalcEbitda(500, 200, 100);
            Assert.Equal(800.0m, result);
        }
    }
}
