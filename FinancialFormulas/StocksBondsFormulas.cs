using System;
using System.Collections;

namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Stocks-and-Bonds-focused Finance/Accounting equations.
    /// </summary>
    public static class StocksBondsFormulas
    {
        public static double CalcBidAskSpread(double bid, double ask)
        {
            return ask - bid;
        }

        public static double CalcBondEquivalentYield(double faceValue, double bondPice, double daysToMaturity)
        {
            return ((faceValue - bondPice) / bondPice) * (365 / daysToMaturity);
        }

        public static double CalcBookValuePerShare(double totalCommonStockholdersEquity, double numberOfCommonShares)
        {
            return totalCommonStockholdersEquity / numberOfCommonShares;
        }

        public static double CalcCapitalAssetPricingModel(double riskFreeRate, double beta, double returnOnTheMarket)
        {
            return riskFreeRate + beta * (returnOnTheMarket - riskFreeRate);
        }

        public static double CalcCapitalGainsYield(double initialStockPrice, double endingStockPrice)
        {
            return (endingStockPrice - initialStockPrice) / initialStockPrice;
        }

        public static double CalcCurrentYield(double annualCoupons, double currentBondPrice)
        {
            return annualCoupons / currentBondPrice;
        }

        public static double CalcDilutedEarningsPerShare(double netIncome, double averageShares, double otherConvertibleInstruments)
        {
            return netIncome / (averageShares + otherConvertibleInstruments);
        }

        public static double CalcDividendPayoutRatio(double dividends, double netIncome)
        {
            return dividends / netIncome;
        }

        public static double CalcDividendYield(double dividendsForThePeriod, double initialPriceForThePeriod)
        {
            return dividendsForThePeriod / initialPriceForThePeriod;
        }

        public static double CalcDividendsPerShare(double dividends, double numberOfShares)
        {
            return dividends / numberOfShares;
        }

        public static double CalcEarningsPerShare(double netIncome, double weightedAverageOutstandingShares)
        {
            return netIncome / weightedAverageOutstandingShares;
        }

        public static double CalcEquityMultiplier(double totalAssets, double stockholdersEquity)
        {
            return totalAssets / stockholdersEquity;
        }

        public static double CalcEquityMultiplier(double equityRatio)
        {
            return 1 / equityRatio;
        }

        public static double CalcEstimatedEarnings(double forecastedSales, double forecastedExpenses)
        {
            return forecastedSales - forecastedExpenses;
        }

        public static double CalcEstimatedEarningsWithProfitMargin(double projectedSales, double projectedNetProfitMargin)
        {
            return projectedSales * projectedNetProfitMargin;

        }

        public static double CalcGeometricMeanReturn(ICollection ratesOfReturn)
        {
            int numberOfPeriods = ratesOfReturn.Count;
            double denominator = 0;
            foreach (double rateOfReturn in ratesOfReturn)
            {
                denominator *= (1 + rateOfReturn);
            }

            if (numberOfPeriods != 0 || denominator != 0)
            {
                return (Math.Pow(denominator, 1 / numberOfPeriods) - 1);
            }
            return 0;
        }

        public static double CalcHoldingPeriodReturn(ICollection percentagePeriodReturns)
        {
            int numberOfPeriods = percentagePeriodReturns.Count;
            double a = 0;
            foreach (double periodReturn in percentagePeriodReturns)
            {
                a *= (1 + periodReturn);
            }

            if (numberOfPeriods != 0 || a != 0)
            {
                return a - 1;
            }
            return 0;
        }

        public static double CalcHoldingPeriodReturn(double periodicRate, double numberOfPeriods)
        {
            return Math.Pow(1 + periodicRate, numberOfPeriods) - 1;
        }

        public static double CalcHoldingPeriodReturn(double earnings, double assetAppreciation, double initialInvestment)
        {
            return (earnings + assetAppreciation) / initialInvestment;   
        }

        public static double CalcNetAssetValue(double fundAssets, double fundLiabilities, double outstandingShares)
        {
            return (fundAssets - fundLiabilities) / outstandingShares;
        }

        public static double CalcPreferredStockValue(double dividend, double discountRate)
        {
            return dividend / discountRate;
        }

        public static double CalcRateOfReturn(double dividend, double price)
        {
            return dividend / price;
        }

        public static double CalcPriceToBookValueRatio(double marketPricePerShare, double bookValuePerShare)
        {
            return marketPricePerShare / bookValuePerShare;
        }

        public static double CalcPriceToEarningsRatio(double pricePerShare, double earningsPerShare)
        {
            return pricePerShare / earningsPerShare;
        }

        public static double CalcPriceToSalesRatio(double pricePerShare, double salesPerShare)
        {
            return pricePerShare / salesPerShare;
        }
    }
}