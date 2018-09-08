using srbrettle.FinancialFormulas;
using System;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_StocksBondsFormulas {

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcBidAskSpread()
        {
            // return ask - bid;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcBondEquivalentYield()
        {
            // return ((faceValue - bondPice) / bondPice) * (365 / daysToMaturity);
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcBookValuePerShare()
        {
            // return totalCommonStockholdersEquity / numberOfCommonShares;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcCapitalAssetPricingModel()
        {
            // return riskFreeRate + beta * (// returnOnTheMarket - riskFreeRate);
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcCapitalGainsYield()
        {
            // return (endingStockPrice - initialStockPrice) / initialStockPrice;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcCurrentYield()
        {
            // return annualCoupons / currentBondPrice;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDilutedEarningsPerShare()
        {
            // return netIncome / (averageShares + otherConvertibleInstruments);
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDividendPayoutRatio()
        {
            // return dividends / netIncome;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDividendYield()
        {
            // return dividendsForThePeriod / initialPriceForThePeriod;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcDividendsPerShare()
        {
            // return dividends / numberOfShares;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcEarningsPerShare()
        {
            // return netIncome / weightedAverageOutstandingShares;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcEquityMultiplier()
        {
            // return totalAssets / stockholdersEquity;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcEquityMultiplierAlternative()
        {
            // return 1 / equityRatio;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcEstimatedEarnings()
        {
            // return forecastedSales - forecastedExpenses;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcEstimatedEarningsWithProfitMargin()
        {
            // return projectedSales * projectedNetProfitMargin;

        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcGeometricMeanReturn()
        {
            /*
            // numberOfPeriods = ratesOfReturn.Count;
            // denominator = 0;
            foreach ()
            {
                denominator *= (1 + rateOfReturn);
            }

            if (numberOfPeriods != 0 || denominator != 0)
            {
                // return (Math.Pow(denominator, 1 / numberOfPeriods) - 1);
            }
            // return 0;
            */
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcHoldingPeriodReturn()
        {
            /*
            int numberOfPeriods = percentagePeriodReturns.Count;
            double a = 0;
            foreach ()
            {
                a *= (1 + periodReturn);
            }

            if (numberOfPeriods != 0 || a != 0)
            {
                // return a - 1;
            }
            // return 0;
            */
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcHoldingPeriodReturnAlternative()
        {
            // return Math.Pow(1 + periodicRate, numberOfPeriods) - 1;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcHoldingPeriodReturnAlternative2()
        {
            // return (earnings + assetAppreciation) / initialInvestment;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcNetAssetValue()
        {
            // return (fundAssets - fundLiabilities) / outstandingShares;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPreferredStockValue()
        {
            // return dividend / discountRate;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcRateOfReturn()
        {
            // return dividend / price;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPriceToBookValueRatio()
        {
            // return marketPricePerShare / bookValuePerShare;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPriceToEarningsRatio()
        {
            // return pricePerShare / earningsPerShare;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcPriceToSalesRatio()
        {
            // return pricePerShare / salesPerShare;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcRiskPremium()
        {
            // return assetOrInvestmentReturn - riskFreeReturn;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcStockPresentValueWithConstantGrowth()
        {
            // return estimatedDividendsForNextPeriod / (requiredRateOfReturn - growthRate);
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcGrowthRate()
        {
            // return retentionRate * // returnOnEquity;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcRequiredRateOfReturn()
        {
            // return dividendYield + growthRate;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcStockPresentValueWithZeroGrowth()
        {
            // return dividendsPerPeriod / requiredRateOfReturn;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcTaxEquivalentYield()
        {
            // return taxFreeYield / (1 - taxRate);
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcTotalStockReturnPercentage()
        {
            // return ((endingStockPrice - initialStockPrice) + dividends) / initialStockPrice;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcTotalStockReturnCash()
        {
            // return (endingStockPrice - initialStockPrice) + dividends;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcTotalStockReturnFromYields()
        {
            // return dividendYield + capitalGainsYield;
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcApproxYieldToMaturity()
        {
            /*
            double numerator = couponOrInterestPayment + ((faceValue - price) / yearsToMaturity);
            double denominator = (faceValue + price) / 2;
            // return (numerator / denominator);
            */
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcZeroCouponBondValue()
        {
            // return faceValue / Math.Pow(1 + rateOrYield, timeToMaturity);
        }

        [Fact(Skip = "Test under development")]
        public void UnitTest_CalcZeroCouponBondYield()
        {
            // return Math.Pow(faceValue / presentValue, 1 / timeToMaturity) - 1;
        }
    }
}