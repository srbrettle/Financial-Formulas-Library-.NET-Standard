using System;
using System.Collections;

namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Stocks-and-Bonds-focused Finance/Accounting equations.
    /// </summary>
    public static class StocksBondsFormulas
    {
        public static decimal CalcBidAskSpread(decimal bid, decimal ask)
        {
            return ask - bid;
        }

        public static decimal CalcBondEquivalentYield(decimal faceValue, decimal bondPice, decimal daysToMaturity)
        {
            return ((faceValue - bondPice) / bondPice) * (365 / daysToMaturity);
        }

        public static decimal CalcBookValuePerShare(decimal totalCommonStockholdersEquity, decimal numberOfCommonShares)
        {
            return totalCommonStockholdersEquity / numberOfCommonShares;
        }

        public static decimal CalcCapitalAssetPricingModel(decimal riskFreeRate, decimal beta, decimal returnOnTheMarket)
        {
            return riskFreeRate + beta * (returnOnTheMarket - riskFreeRate);
        }

        public static decimal CalcCapitalGainsYield(decimal initialStockPrice, decimal endingStockPrice)
        {
            return (endingStockPrice - initialStockPrice) / initialStockPrice;
        }

        public static decimal CalcCurrentYield(decimal annualCoupons, decimal currentBondPrice)
        {
            return annualCoupons / currentBondPrice;
        }

        public static decimal CalcDilutedEarningsPerShare(decimal netIncome, decimal averageShares, decimal otherConvertibleInstruments)
        {
            return netIncome / (averageShares + otherConvertibleInstruments);
        }

        public static decimal CalcDividendPayoutRatio(decimal dividends, decimal netIncome)
        {
            return dividends / netIncome;
        }

        public static decimal CalcDividendYield(decimal dividendsForThePeriod, decimal initialPriceForThePeriod)
        {
            return dividendsForThePeriod / initialPriceForThePeriod;
        }

        public static decimal CalcDividendsPerShare(decimal dividends, decimal numberOfShares)
        {
            return dividends / numberOfShares;
        }

        public static decimal CalcEarningsPerShare(decimal netIncome, decimal weightedAverageOutstandingShares)
        {
            return netIncome / weightedAverageOutstandingShares;
        }

        public static decimal CalcEquityMultiplier(decimal totalAssets, decimal stockholdersEquity)
        {
            return totalAssets / stockholdersEquity;
        }

        public static decimal CalcEquityMultiplier(decimal equityRatio)
        {
            return 1 / equityRatio;
        }

        public static decimal CalcEstimatedEarnings(decimal forecastedSales, decimal forecastedExpenses)
        {
            return forecastedSales - forecastedExpenses;
        }

        public static decimal CalcEstimatedEarningsWithProfitMargin(decimal projectedSales, decimal projectedNetProfitMargin)
        {
            return projectedSales * projectedNetProfitMargin;

        }

        public static decimal CalcGeometricMeanReturn(ICollection ratesOfReturn)
        {
            int numberOfPeriods = ratesOfReturn.Count;
            decimal denominator = 0;
            foreach (decimal rateOfReturn in ratesOfReturn)
            {
                denominator *= (1 + rateOfReturn);
            }

            if (numberOfPeriods != 0 || denominator != 0)
            {
                return (decimal)Math.Pow((double)denominator, 1 / numberOfPeriods) - 1;
            }
            return 0;
        }

        public static decimal CalcHoldingPeriodReturn(ICollection percentagePeriodReturns)
        {
            int numberOfPeriods = percentagePeriodReturns.Count;
            decimal a = 0;
            foreach (decimal periodReturn in percentagePeriodReturns)
            {
                a *= (1 + periodReturn);
            }

            if (numberOfPeriods != 0 || a != 0)
            {
                return a - 1;
            }
            return 0;
        }

        public static decimal CalcHoldingPeriodReturn(decimal periodicRate, decimal numberOfPeriods)
        {
            return (decimal)Math.Pow((double)(1 + periodicRate), (double)numberOfPeriods) - 1;
        }

        public static decimal CalcHoldingPeriodReturn(decimal earnings, decimal assetAppreciation, decimal initialInvestment)
        {
            return (earnings + assetAppreciation) / initialInvestment;   
        }

        public static decimal CalcNetAssetValue(decimal fundAssets, decimal fundLiabilities, decimal outstandingShares)
        {
            return (fundAssets - fundLiabilities) / outstandingShares;
        }

        public static decimal CalcPreferredStockValue(decimal dividend, decimal discountRate)
        {
            return dividend / discountRate;
        }

        public static decimal CalcRateOfReturn(decimal dividend, decimal price)
        {
            return dividend / price;
        }

        public static decimal CalcPriceToBookValueRatio(decimal marketPricePerShare, decimal bookValuePerShare)
        {
            return marketPricePerShare / bookValuePerShare;
        }

        public static decimal CalcPriceToEarningsRatio(decimal pricePerShare, decimal earningsPerShare)
        {
            return pricePerShare / earningsPerShare;
        }

        public static decimal CalcPriceToSalesRatio(decimal pricePerShare, decimal salesPerShare)
        {
            return pricePerShare / salesPerShare;
        }

        public static decimal CalcRiskPremium(decimal assetOrInvestmentReturn, decimal riskFreeReturn)
        {
            return assetOrInvestmentReturn - riskFreeReturn;
        }        

        public static decimal CalcStockPresentValueWithConstantGrowth(decimal estimatedDividendsForNextPeriod, decimal requiredRateOfReturn, decimal growthRate)
        {
            return estimatedDividendsForNextPeriod / (requiredRateOfReturn - growthRate);
        }

        public static decimal CalcGrowthRate(decimal retentionRate, decimal returnOnEquity)
        {
            return retentionRate * returnOnEquity;
        }

        public static decimal CalcRequiredRateOfReturn(decimal dividendYield, decimal growthRate)
        {
            return dividendYield + growthRate;
        }

        public static decimal CalcStockPresentValueWithZeroGrowth(decimal dividendsPerPeriod, decimal requiredRateOfReturn)
        {
            return dividendsPerPeriod / requiredRateOfReturn;
        }

        public static decimal CalcTaxEquivanlentYield(decimal taxFreeYield, decimal taxRate)
        {
            return taxFreeYield / (1 - taxRate);
        }

        public static decimal CalcTotalStockReturnPercentage(decimal initialStockPrice, decimal endingStockPrice, decimal dividends)
        {
            return ((endingStockPrice - initialStockPrice) + dividends) / initialStockPrice;
        }

        public static decimal CalcTotalStockReturnCash(decimal initialStockPrice, decimal endingStockPrice, decimal dividends)
        {
            return (endingStockPrice - initialStockPrice) + dividends;
        }

        public static decimal CalcTotalStockReturnFromYields(decimal dividendYield, decimal capitalGainsYield)
        {
            return dividendYield + capitalGainsYield;
        }

        public static decimal CalcApproxYieldToMaturity(decimal couponOrInterestPayment, decimal faceValue, decimal price, decimal yearsToMaturity)
        {
            decimal numerator = couponOrInterestPayment + ((faceValue - price) / yearsToMaturity);
            decimal denominator = (faceValue + price) / 2;
            return (numerator/denominator);
        }

        public static decimal CalcZeroCouponBondValue(decimal faceValue, decimal rateOrYield, decimal timeToMaturity)
        {
            return faceValue / (decimal)Math.Pow((double)(1 + rateOrYield), (double)timeToMaturity);
        }

        public static decimal CalcZeroCouponBondYield(decimal faceValue, decimal presentValue, decimal timeToMaturity)
        {
            return (decimal)Math.Pow((double)(faceValue / presentValue), (double)(1 / timeToMaturity)) - 1;
        }
    }
}