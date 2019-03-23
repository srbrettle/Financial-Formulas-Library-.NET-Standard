using System;
using System.Collections;

namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Stocks-and-Bonds-focused Finance/Accounting equations.
    /// </summary>
    public static class StocksBondsFormulas
    {
        /// <summary>
        /// Calculates Bid Ask Spread from Bid and Ask
        /// </summary>
        /// <param name="bid">Bid</param>
        /// <param name="ask">Ask</param>
        /// <returns>Decimal value for Bid Ask Spread</returns>
        public static decimal CalcBidAskSpread(decimal bid, decimal ask)
        {
            return ask - bid;
        }

        /// <summary>
        /// Calculates Bond Equivalent Yield from Face Value, Bond Price and Days to Maturity
        /// </summary>
        /// <param name="faceValue">Face Value</param>
        /// <param name="bondPrice">Bond Price</param>
        /// <param name="daysToMaturity">Days to Maturity</param>
        /// <returns>Decimal value for Bond Equivalent Yield</returns>
        public static decimal CalcBondEquivalentYield(decimal faceValue, decimal bondPrice, decimal daysToMaturity)
        {
            return ((faceValue - bondPrice) / bondPrice) * (365 / daysToMaturity);
        }

        /// <summary>
        /// Calculates Book Value per Share from Total Common Stockholders Equity and Number of Common Shares
        /// </summary>
        /// <param name="totalCommonStockholdersEquity">Total Common Stockholders Equity</param>
        /// <param name="numberOfCommonShares">Number of Common Shares</param>
        /// <returns>Decimal value for Book Value per Share</returns>
        public static decimal CalcBookValuePerShare(decimal totalCommonStockholdersEquity, decimal numberOfCommonShares)
        {
            return totalCommonStockholdersEquity / numberOfCommonShares;
        }

        /// <summary>
        /// Calculates Capital Asset Pricing Model from Risk-Free Rate, Beta and Return on the Market
        /// </summary>
        /// <param name="riskFreeRate">Risk-Free Rate</param>
        /// <param name="beta">Beta</param>
        /// <param name="returnOnTheMarket">Return on the Market</param>
        /// <returns>Decimal value for Capital Asset Pricing Model</returns>
        public static decimal CalcCapitalAssetPricingModel(decimal riskFreeRate, decimal beta, decimal returnOnTheMarket)
        {
            return riskFreeRate + beta * (returnOnTheMarket - riskFreeRate);
        }

        /// <summary>
        /// Calculates Capital Gains Yield from Initial Stock Price and Ending Stock Price
        /// </summary>
        /// <param name="initialStockPrice">Initial Stock Price</param>
        /// <param name="endingStockPrice">Ending Stock Price</param>
        /// <returns>Decimal value for Capital Gains Yield</returns>
        public static decimal CalcCapitalGainsYield(decimal initialStockPrice, decimal endingStockPrice)
        {
            return (endingStockPrice - initialStockPrice) / initialStockPrice;
        }

        /// <summary>
        /// Calculates Current Yield from Annual Coupons and Current Bond Price
        /// </summary>
        /// <param name="annualCoupons">Annual Coupons</param>
        /// <param name="currentBondPrice">Current Bond Price</param>
        /// <returns>Decimal value for Current Yield</returns>
        public static decimal CalcCurrentYield(decimal annualCoupons, decimal currentBondPrice)
        {
            return annualCoupons / currentBondPrice;
        }

        /// <summary>
        /// Calculate Diluted Earnings per Share from Net Income, Average Shares and Other Convertible Instruments
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="averageShares">Average Shares</param>
        /// <param name="otherConvertibleInstruments">Other Convertible Instruments</param>
        /// <returns>Decimal value for Diluted Earnings per Share</returns>
        public static decimal CalcDilutedEarningsPerShare(decimal netIncome, decimal averageShares, decimal otherConvertibleInstruments)
        {
            return netIncome / (averageShares + otherConvertibleInstruments);
        }

        /// <summary>
        /// Calculates Dividends Payout Ratio from Dividends and Net Income
        /// </summary>
        /// <param name="dividends">Dividends</param>
        /// <param name="netIncome">Net Income</param>
        /// <returns>Decimal value for Dividends Payout Ratio</returns>
        public static decimal CalcDividendPayoutRatio(decimal dividends, decimal netIncome)
        {
            return dividends / netIncome;
        }

        /// <summary>
        /// Calculates Dividend Yield from Dividends for the Period and Initial Price for the Period
        /// </summary>
        /// <param name="dividendsForThePeriod">Dividends for the Period</param>
        /// <param name="initialPriceForThePeriod">Initial Price for the Period</param>
        /// <returns>Decimal value for Dividend Yield</returns>
        public static decimal CalcDividendYield(decimal dividendsForThePeriod, decimal initialPriceForThePeriod)
        {
            return dividendsForThePeriod / initialPriceForThePeriod;
        }

        /// <summary>
        /// Calculates Dividends per Share from Dividends and Number of Shares
        /// </summary>
        /// <param name="dividends">Dividends</param>
        /// <param name="numberOfShares">Number of Shares</param>
        /// <returns>Decimal value for Dividends per Share</returns>
        public static decimal CalcDividendsPerShare(decimal dividends, decimal numberOfShares)
        {
            return dividends / numberOfShares;
        }

        /// <summary>
        /// Calculates Earnings per Share from Net Income and Weighted Average Outstanding Shares
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="weightedAverageOutstandingShares">Weighted Average Outstanding Shares</param>
        /// <returns>Decimal value for Earnings per Share</returns>
        public static decimal CalcEarningsPerShare(decimal netIncome, decimal weightedAverageOutstandingShares)
        {
            return netIncome / weightedAverageOutstandingShares;
        }

        /// <summary>
        /// Calculates Equity Multiplier from Total Assets and Stockholders Equity
        /// </summary>
        /// <param name="totalAssets">Total Assets</param>
        /// <param name="stockholdersEquity">Stockholders Equity</param>
        /// <returns>Decimal value for Equity Multiplier</returns>
        public static decimal CalcEquityMultiplier(decimal totalAssets, decimal stockholdersEquity)
        {
            return totalAssets / stockholdersEquity;
        }

        /// <summary>
        /// Calculates Equity Multiplier from Equity Ratio
        /// </summary>
        /// <param name="equityRatio">Equity Ratio</param>
        /// <returns>Decimal value for Equity Multiplier</returns>
        public static decimal CalcEquityMultiplier(decimal equityRatio)
        {
            return 1 / equityRatio;
        }

        /// <summary>
        /// Calculates Estimated Earnings from Forecasted Sales and Forecasted Expenses
        /// </summary>
        /// <param name="forecastedSales">Forecasted Sales</param>
        /// <param name="forecastedExpenses">Forecasted Expenses</param>
        /// <returns>Decimal value for Estimated Earnings</returns>
        public static decimal CalcEstimatedEarnings(decimal forecastedSales, decimal forecastedExpenses)
        {
            return forecastedSales - forecastedExpenses;
        }

        /// <summary>
        /// Calculates Estimated Earnings with Profit Margin from Projected Sales and Projected Net Profit Margin
        /// </summary>
        /// <param name="projectedSales">Projected Sales</param>
        /// <param name="projectedNetProfitMargin">Projected Net Profit Margin</param>
        /// <returns>Decimal value for Estimated Earnings with Profit Margin</returns>
        public static decimal CalcEstimatedEarningsWithProfitMargin(decimal projectedSales, decimal projectedNetProfitMargin)
        {
            return projectedSales * projectedNetProfitMargin;
        }

        /// <summary>
        /// Calculates Geometric Mean Return from Rates of Return
        /// </summary>
        /// <param name="ratesOfReturn">Rates Of Return</param>
        /// <returns>Decimal value for Geometric Mean Return</returns>
        public static decimal CalcGeometricMeanReturn(ICollection ratesOfReturn)
        {
            int numberOfPeriods = ratesOfReturn.Count;
            decimal root = 1;
            foreach (decimal rateOfReturn in ratesOfReturn)
            {                
                root *= (1 + rateOfReturn);
            }

            if (numberOfPeriods > 0)
            {                
                return (decimal)Math.Pow((double)root, (double) decimal.Divide(1, numberOfPeriods)) - 1;
            }

            return 0;
        }

        /// <summary>
        /// Calculates Holding Period Return from Percentage Period Returns
        /// </summary>
        /// <param name="percentagePeriodReturns">Percentage Period Returns</param>
        /// <returns>Decimal value for Holding Period Return</returns>
        public static decimal CalcHoldingPeriodReturn(ICollection percentagePeriodReturns)
        {
            int numberOfPeriods = percentagePeriodReturns.Count;
            decimal a = 1;
            foreach (decimal periodReturn in percentagePeriodReturns)
            {
                a *= (1 + periodReturn);
            }

            if (numberOfPeriods > 0)
            {
                return a - 1;
            }

            return 0;
        }

        /// <summary>
        /// Calculates Holding Period Return from Periodic Rate and Number of Periods
        /// </summary>
        /// <param name="periodicRate">Periodic Rate</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Holding Period Return</returns>
        public static decimal CalcHoldingPeriodReturn(decimal periodicRate, decimal numberOfPeriods)
        {
            return (decimal)Math.Pow((double)(1 + periodicRate), (double)numberOfPeriods) - 1;
        }

        /// <summary>
        /// Calculates Holding Period Return from Earnings, Asset Appreciation and Initial Investment
        /// </summary>
        /// <param name="earnings">Earnings</param>
        /// <param name="assetAppreciation">Asset Appreciation</param>
        /// <param name="initialInvestment">Initial Investment</param>
        /// <returns>Decimal value for Holding Period Return</returns>
        public static decimal CalcHoldingPeriodReturn(decimal earnings, decimal assetAppreciation, decimal initialInvestment)
        {
            return (earnings + assetAppreciation) / initialInvestment;   
        }

        /// <summary>
        /// Calculates Net Asset Value from Fund Assets, Fund Liabilities and Outstanding Shares
        /// </summary>
        /// <param name="fundAssets">Fund Assets</param>
        /// <param name="fundLiabilities">Fund Liabilities</param>
        /// <param name="outstandingShares">Outstanding Shares</param>
        /// <returns>Decimal value for Net Asset Value</returns>
        public static decimal CalcNetAssetValue(decimal fundAssets, decimal fundLiabilities, decimal outstandingShares)
        {
            return (fundAssets - fundLiabilities) / outstandingShares;
        }

        /// <summary>
        /// Calculates Preferred Stock Value from Dividend and Discount Rate
        /// </summary>
        /// <param name="dividend">Dividend</param>
        /// <param name="discountRate">Discount Rate</param>
        /// <returns>Decimal value for Preferred Stock Value</returns>
        public static decimal CalcPreferredStockValue(decimal dividend, decimal discountRate)
        {
            return dividend / discountRate;
        }

        /// <summary>
        /// Calculates Rate of Return from Dividend and Price
        /// </summary>
        /// <param name="dividend">Dividend</param>
        /// <param name="price">Price</param>
        /// <returns>Decimal value for Rate of Return</returns>
        public static decimal CalcRateOfReturn(decimal dividend, decimal price)
        {
            return dividend / price;
        }

        /// <summary>
        /// Calculates Price to Book Value Ratio from Market Price per Share and Book Value per Share
        /// </summary>
        /// <param name="marketPricePerShare">Market Price per Share</param>
        /// <param name="bookValuePerShare">Book Value per Share</param>
        /// <returns>Decimal value for Price to Book Value Ratio</returns>
        public static decimal CalcPriceToBookValueRatio(decimal marketPricePerShare, decimal bookValuePerShare)
        {
            return marketPricePerShare / bookValuePerShare;
        }
        /// <summary>
        /// Calculates Price to Earnings Ratio from Price per Share and Earnings per Share
        /// </summary>
        /// <param name="pricePerShare">Price per Share</param>
        /// <param name="earningsPerShare">Earnings per Share</param>
        /// <returns>Decimal value for Price to Earnings Ratio</returns>
        public static decimal CalcPriceToEarningsRatio(decimal pricePerShare, decimal earningsPerShare)
        {
            return pricePerShare / earningsPerShare;
        }

        /// <summary>
        /// Calculates Price to Sales Ratio from Price per Share and Sales per Share
        /// </summary>
        /// <param name="pricePerShare">Price per Share</param>
        /// <param name="salesPerShare">Sales per Share</param>
        /// <returns>Decimal value for Price to Sales Ratio</returns>
        public static decimal CalcPriceToSalesRatio(decimal pricePerShare, decimal salesPerShare)
        {
            return pricePerShare / salesPerShare;
        }

        /// <summary>
        /// Calculates Risk Premium from Asset or Investment Return and Risk Free Return
        /// </summary>
        /// <param name="assetOrInvestmentReturn">Asset or Investment Return</param>
        /// <param name="riskFreeReturn">Risk-Free Return</param>
        /// <returns>Decimal value for Risk Premium</returns>
        public static decimal CalcRiskPremium(decimal assetOrInvestmentReturn, decimal riskFreeReturn)
        {
            return assetOrInvestmentReturn - riskFreeReturn;
        }

        /// <summary>
        /// Calculates Stock Present Value with Constant Growth from Estimated Dividends for Next Period, Required Rate Of Return and Growth Rate
        /// </summary>
        /// <param name="estimatedDividendsForNextPeriod">Estimated Dividends for Next Period</param>
        /// <param name="requiredRateOfReturn">Required Rate Of Return</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <returns>Decimal value for Stock Present Value with Constant Growth</returns>
        public static decimal CalcStockPresentValueWithConstantGrowth(decimal estimatedDividendsForNextPeriod, decimal requiredRateOfReturn, decimal growthRate)
        {
            return estimatedDividendsForNextPeriod / (requiredRateOfReturn - growthRate);
        }

        /// <summary>
        /// Calculates Growth Rate from Retention Rate and Return on Equity
        /// </summary>
        /// <param name="retentionRate">Retention Rate</param>
        /// <param name="returnOnEquity">Return on Equity</param>
        /// <returns>Decimal value for Growth Rate</returns>
        public static decimal CalcGrowthRate(decimal retentionRate, decimal returnOnEquity)
        {
            return retentionRate * returnOnEquity;
        }

        /// <summary>
        /// Calculates Required Rate of Return from Dividend Yield and Growth Rate
        /// </summary>
        /// <param name="dividendYield">Dividend Yield</param>
        /// <param name="growthRate">Growth Rate</param>
        /// <returns>Decimal value for Required Rate of Return</returns>
        public static decimal CalcRequiredRateOfReturn(decimal dividendYield, decimal growthRate)
        {
            return dividendYield + growthRate;
        }

        /// <summary>
        /// Calculates Stock Present Value with Zero Growth from Dividends per Period and Required Rate of Return
        /// </summary>
        /// <param name="dividendsPerPeriod">Dividends per Period</param>
        /// <param name="requiredRateOfReturn">Required Rate of Return</param>
        /// <returns>Decimal value for Stock Present Value with Zero Growth</returns>
        public static decimal CalcStockPresentValueWithZeroGrowth(decimal dividendsPerPeriod, decimal requiredRateOfReturn)
        {
            return dividendsPerPeriod / requiredRateOfReturn;
        }

        /// <summary>
        /// Calculates Tax Equivalent Yield from Tax-Free Yield and Tax Rate
        /// </summary>
        /// <param name="taxFreeYield">Tax-Free Yield</param>
        /// <param name="taxRate">Tax Rate</param>
        /// <returns>Decimal value for Tax Equivalent Yield</returns>
        public static decimal CalcTaxEquivalentYield(decimal taxFreeYield, decimal taxRate)
        {
            return taxFreeYield / (1 - taxRate);
        }

        /// <summary>
        /// Calculates Total Stock Return Percentage from Initial Stock Price, Ending Stock Price and Dividends
        /// </summary>
        /// <param name="initialStockPrice">Initial Stock Price</param>
        /// <param name="endingStockPrice">Ending Stock Price</param>
        /// <param name="dividends">Dividends</param>
        /// <returns>Decimal value for Total Stock Return Percentage</returns>
        public static decimal CalcTotalStockReturnPercentage(decimal initialStockPrice, decimal endingStockPrice, decimal dividends)
        {
            return ((endingStockPrice - initialStockPrice) + dividends) / initialStockPrice;
        }

        /// <summary>
        /// Calculates Total Stock Return Cash from Initial Stock Price, Ending Stock Price and Dividends
        /// </summary>
        /// <param name="initialStockPrice">Initial Stock Price</param>
        /// <param name="endingStockPrice">Ending Stock Price</param>
        /// <param name="dividends">Dividends</param>
        /// <returns>Decimal value for Total Stock Return Cash</returns>
        public static decimal CalcTotalStockReturnCash(decimal initialStockPrice, decimal endingStockPrice, decimal dividends)
        {
            return (endingStockPrice - initialStockPrice) + dividends;
        }

        /// <summary>
        /// Calculates Total Stock Return by Yields from Dividend Yield and Capital Gains Yield
        /// </summary>
        /// <param name="dividendYield">Dividend Yield</param>
        /// <param name="capitalGainsYield">Capital Gains Yield</param>
        /// <returns>Decimal value for Total Stock Return by Yields</returns>
        public static decimal CalcTotalStockReturnFromYields(decimal dividendYield, decimal capitalGainsYield)
        {
            return dividendYield + capitalGainsYield;
        }

        /// <summary>
        /// Calculates Approximate Yield to Maturity from Coupon/Interest Payment, Face Value, Price and Years to Maturity
        /// </summary>
        /// <param name="couponOrInterestPayment">Coupon/Interest Payment</param>
        /// <param name="faceValue">Face Value</param>
        /// <param name="price">Price</param>
        /// <param name="yearsToMaturity">Years to Maturity</param>
        /// <returns>Decimal value for Approximate Yield to Maturity</returns>
        public static decimal CalcApproxYieldToMaturity(decimal couponOrInterestPayment, decimal faceValue, decimal price, decimal yearsToMaturity)
        {
            decimal numerator = couponOrInterestPayment + ((faceValue - price) / yearsToMaturity);
            decimal denominator = (faceValue + price) / 2;
            return (numerator / denominator);
        }

        /// <summary>
        /// Calculates Zero Coupon Bond Value from Face Value, Rate/Yield and Time to Maturity
        /// </summary>
        /// <param name="faceValue">Face Value</param>
        /// <param name="rateOrYield">Rate (Yield)</param>
        /// <param name="timeToMaturity">Time to Maturity</param>
        /// <returns>Decimal value for Zero Coupon Bond Value</returns>
        public static decimal CalcZeroCouponBondValue(decimal faceValue, decimal rateOrYield, decimal timeToMaturity)
        {
            return faceValue / (decimal)Math.Pow((double)(1 + rateOrYield), (double)timeToMaturity);
        }

        /// <summary>
        /// Calculates Zero Coupon Bond Yield from Face Value, Present Value and Time to Maturity
        /// </summary>
        /// <param name="faceValue">Face Value</param>
        /// <param name="presentValue">Present Value</param>
        /// <param name="timeToMaturity">Time to Maturity</param>
        /// <returns>Decimal value for Zero Coupon Bond Yield</returns>
        public static decimal CalcZeroCouponBondYield(decimal faceValue, decimal presentValue, decimal timeToMaturity)
        {
            return (decimal)Math.Pow((double)(faceValue / presentValue), (double)(1 / timeToMaturity)) - 1;
        }
    }
}