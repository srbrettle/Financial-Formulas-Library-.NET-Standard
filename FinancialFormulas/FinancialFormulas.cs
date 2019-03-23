namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Finance/Accounting equations.
    /// </summary>
    public static class FinancialFormulas
    {
        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Activity                                                       |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Asset Turnover from Net Sales and Total Assets
        /// </summary>
        /// <param name="netSales">Net Sales</param>
        /// <param name="totalAssets">Total Assets</param>
        /// <returns>Decimal value for Asset Turnover</returns>
        public static decimal CalcAssetTurnover(decimal netSales, decimal totalAssets)
        {
            return netSales / totalAssets;
        }

        /// <summary>
        /// Calculates Average Collection Period from Accounts Receivable and Annual Credit Sales
        /// </summary>
        /// <param name="accountsReceivable">Accounts Receivable</param>
        /// <param name="annualCreditSales">Annual Credit Sales</param>
        /// <returns>Decimal value for Average Collection Period</returns>
        public static decimal CalcAverageCollectionPeriod(decimal accountsReceivable, decimal annualCreditSales)
        {
            return accountsReceivable / (annualCreditSales / 365);
        }

        /// <summary>
        /// Calculates Cash Conversion Cycle from Inventory Conversion Period, Receivables Conversion Period and Payables Conversion Period
        /// </summary>
        /// <param name="inventoryConversionPeriod">Inventory Conversion Period</param>
        /// <param name="receivablesConversionPeriod">Receivables Conversion Period</param>
        /// <param name="payablesConversionPeriod">Payables Conversion Period</param>
        /// <returns>Decimal value for Cash Conversion Cycle</returns>
        public static decimal CalcCashConversionCycle(decimal inventoryConversionPeriod, decimal receivablesConversionPeriod, decimal payablesConversionPeriod)
        {
            return (inventoryConversionPeriod
                    + receivablesConversionPeriod - payablesConversionPeriod);
        }

        /// <summary>
        /// Calculates Inventory Conversion Period from Inventory Turnover Ratio
        /// </summary>
        /// <param name="inventoryTurnoverRatio">Inventory Turnover Ratio</param>
        /// <returns>Decimal value for Inventory Conversion Period</returns>
        public static decimal CalcInventoryConversionPeriod(decimal inventoryTurnoverRatio)
        {
            return 365 / inventoryTurnoverRatio;
        }

        /// <summary>
        /// Calculates Inventory Conversion Ratio from Sales and Cost Of Goods Sold
        /// </summary>
        /// <param name="sales">Sales</param>
        /// <param name="costOfGoodsSold">Cost Of Goods Sold</param>
        /// <returns>Decimal value for Inventory Conversion Ratio</returns>
        public static decimal CalcInventoryConversionRatio(decimal sales, decimal costOfGoodsSold)
        {
            return (sales / 2) / costOfGoodsSold;
        }

        /// <summary>
        /// Calculates Inventory Turnover from Sales and Average Inventory
        /// </summary>
        /// <param name="sales">Sales</param>
        /// <param name="averageInventory">Average Inventory</param>
        /// <returns>Decimal value for Inventory Turnover</returns>
        public static decimal CalcInventoryTurnover(decimal sales, decimal averageInventory)
        {
            return sales / averageInventory;
        }

        /// <summary>
        /// Calculates Payables Conversion Period from Accounts Payable and Purchases
        /// </summary>
        /// <param name="accountsPayable">Accounts Payable</param>
        /// <param name="purchases">Purchases</param>
        /// <returns>Decimal value for Payables Conversion Period</returns>
        public static decimal CalcPayablesConversionPeriod(decimal accountsPayable, decimal purchases)
        {
            return (accountsPayable / purchases) * 365;
        }

        /// <summary>
        /// Calculates Receivables Conversion Period from Receivables and Net Sales
        /// </summary>
        /// <param name="receivables">Receivables</param>
        /// <param name="netSales">Net Sales</param>
        /// <returns>Decimal value for Receivables Conversion Period</returns>
        public static decimal CalcReceivablesConversionPeriod(decimal receivables, decimal netSales)
        {
            return (receivables / netSales) * 365;
        }

        /// <summary>
        /// Calculates Receivables Turnover Ratio from Net Credit Sales and Average Net Receivables
        /// </summary>
        /// <param name="netCreditSales">Net Credit Sales</param>
        /// <param name="averageNetReceivables">Average Net Receivables</param>
        /// <returns>Decimal value for Receivables Turnover Ratio</returns>
        public static decimal CalcReceivablesTurnoverRatio(decimal netCreditSales, decimal averageNetReceivables)
        {
            return netCreditSales / averageNetReceivables;
        }

        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Basic                                                          |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Assets from Liabilities and Equity
        /// </summary>
        /// <param name="liabilities">Liabilities</param>
        /// <param name="equity">Equity</param>
        /// <returns>Decimal value for Assets</returns>
        public static decimal CalcAssets(decimal liabilities, decimal equity)
        {
            return liabilities + equity;
        }

        /// <summary>
        /// Calculates Earnings Before Interest and Taxes (EBIT) from Revenue and Operating Expenses
        /// </summary>
        /// <param name="revenue">Revenue</param>
        /// <param name="operatingExpenses">Operating Expenses</param>
        /// <returns>Decimal value for EBIT</returns>
        public static decimal CalcEbit(decimal revenue, decimal operatingExpenses)
        {
            return revenue - operatingExpenses;
        }

        /// <summary>
        /// Calculates Equity from Assets and Liabilities
        /// </summary>
        /// <param name="assets">Assets</param>
        /// <param name="liabilities">Liabilities</param>
        /// <returns>Decimal value for Equity</returns>
        public static decimal CalcEquity(decimal assets, decimal liabilities)
        {
            return assets - liabilities;
        }

        /// <summary>
        /// Calculates Gross Profit from Revenue and Cost Of Goods Sold (COGS)
        /// </summary>
        /// <param name="revenue">Revenue</param>
        /// <param name="costOfGoodsSold">Cost Of Goods Sold</param>
        /// <returns>Decimal value for Gross Profit</returns>
        public static decimal CalcGrossProfit(decimal revenue, decimal costOfGoodsSold)
        {
            return revenue - costOfGoodsSold;
        }

        /// <summary>
        /// Calculates Liabilities from Assets and Equity
        /// </summary>
        /// <param name="assets">Assets</param>
        /// <param name="equity">Equity</param>
        /// <returns>Decimal value for Liabilities</returns>
        public static decimal CalcLiabilities(decimal assets, decimal equity)
        {
            return assets - equity;
        }

        /// <summary>
        /// Calculates Net Profit from Gross Profit, Operating Expenses, Taxes and Interest
        /// </summary>
        /// <param name="grossProfit">Gross Profit</param>
        /// <param name="operatingExpenses">Operating Expenses</param>
        /// <param name="taxes">Taxes</param>
        /// <param name="interest">Interest</param>
        /// <returns>Decimal value for Net Profit</returns>
        public static decimal CalcNetProfit(decimal grossProfit, decimal operatingExpenses, decimal taxes, decimal interest)
        {
            return grossProfit - operatingExpenses - taxes - interest;
        }

        /// <summary>
        /// Calculates Operation Profit from Gross Profit and Operating Expenses
        /// </summary>
        /// <param name="grossProfit">Gross Profit</param>
        /// <param name="operatingExpenses">Operating Expenses</param>
        /// <returns>Decimal value for Operating Profit</returns>
        public static decimal CalcOperatingProfit(decimal grossProfit, decimal operatingExpenses)
        {
            return grossProfit - operatingExpenses;
        }

        /// <summary>
        /// Calculates Sales Revenue from Gross Sales and Sales of Returns and Allowances
        /// </summary>
        /// <param name="grossSales">Gross Sales</param>
        /// <param name="salesOfReturnsAndAllowances">Sales of Returns and Allowances</param>
        /// <returns>Decimal value for Sales Revenue</returns>
        public static decimal CalcSalesRevenue(decimal grossSales, decimal salesOfReturnsAndAllowances)
        {
            return grossSales - salesOfReturnsAndAllowances;
        }

        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Debt                                                           |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Debt to Equity Ratio from Total Liabilities and Shareholder Equity
        /// </summary>
        /// <param name="totalLiabilities">Total Liabilities</param>
        /// <param name="shareholderEquity">Shareholder Equity</param>
        /// <returns>Decimal value for Debt to Equity Ratio</returns>
        public static decimal CalcDebtEquityRatio(decimal totalLiabilities, decimal shareholderEquity)
        {
            return totalLiabilities / shareholderEquity;
        }

        /// <summary>
        /// Calculates Debt Ratio from Total Liabilities and Total Assets
        /// </summary>
        /// <param name="totalLiabilities">Total Liabilities</param>
        /// <param name="totalAssets">Total Assets</param>
        /// <returns>Decimal value for Debt Ratio</returns>
        public static decimal CalcDebtRatio(decimal totalLiabilities, decimal totalAssets)
        {
            return totalLiabilities / totalAssets;
        }

        /// <summary>
        /// Calculates Debt-Service Coverage Ratio from Net Operating Income and Total Debt Service
        /// </summary>
        /// <param name="netOperatingIncome">Net Operating Income</param>
        /// <param name="totalDebtService">Total Debt Service</param>
        /// <returns>Decimal value for Debt-Service Coverage Ratio</returns>
        public static decimal CalcDebtServiceCoverageRatio(decimal netOperatingIncome, decimal totalDebtService)
        {
            return netOperatingIncome / totalDebtService;
        }

        /// <summary>
        /// Calculates Long-Term Debt to Equity Ratio from Long-Term Liabilities and Equity
        /// </summary>
        /// <param name="longTermLiabilities">Long-Term Liabilities</param>
        /// <param name="equity">Equity</param>
        /// <returns>Decimal value for Long-Term Debt to Equity Ratio</returns>
        public static decimal CalcLongTermDebtEquityRatio(decimal longTermLiabilities, decimal equity)
        {
            return longTermLiabilities / equity;
        }

        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Depreciation                                                   |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Book Value from Acquisition Cost and Depreciation
        /// </summary>
        /// <param name="acquisitionCost">Acquisition Cost</param>
        /// <param name="depreciation">Depreciation</param>
        /// <returns>Decimal value for Book Value</returns>
        public static decimal CalcBookValue(decimal acquisitionCost, decimal depreciation)
        {
            return acquisitionCost - depreciation;
        }

        /// <summary>
        /// Calculates Declining Balance from Depreciation Rate and Book Value at Beginning of Year
        /// </summary>
        /// <param name="depreciationRate">Depreciation Rate</param>
        /// <param name="bookValueAtBeginningOfYear">Book Value at Beginning of Year</param>
        /// <returns>Decimal value for Declining Balance</returns>
        public static decimal CalcDecliningBalance(decimal depreciationRate, decimal bookValueAtBeginningOfYear)
        {
            return depreciationRate * bookValueAtBeginningOfYear;
        }

        /// <summary>
        /// Calculates Units Of Production from Cost of Asset, Residual Value, Estimated Total Production and Actual Production
        /// </summary>
        /// <param name="costOfAsset">Cost of Asset</param>
        /// <param name="residualValue">Residual Value</param>
        /// <param name="estimatedTotalProduction">Estimated Total Production</param>
        /// <param name="actualProduction">Actual Production</param>
        /// <returns>Decimal value for Units of Production</returns>
        public static decimal CalcUnitsOfProduction(decimal costOfAsset, decimal residualValue, decimal estimatedTotalProduction, decimal actualProduction)
        {
            return ((costOfAsset - residualValue) / estimatedTotalProduction) * actualProduction;
        }

        /// <summary>
        /// Calculates Straight Line Method from Cost of Fixed Asset, Residual Value and Useful Life of Asset
        /// </summary>
        /// <param name="costOfFixedAsset">Cost of Fixed Asset</param>
        /// <param name="residualValue">Residual Value</param>
        /// <param name="usefulLifeOfAsset">Useful Life of Asset</param>
        /// <returns>Decimal value for Straight Line Method</returns>
        public static decimal CalcStraightLineMethod(decimal costOfFixedAsset, decimal residualValue, decimal usefulLifeOfAsset)
        {
            return (costOfFixedAsset - residualValue) / usefulLifeOfAsset;
        }

        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Liquidity                                                      |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Cash Ration from Cash, Marketable Securities and Current Liabilities
        /// </summary>
        /// <param name="cash">Cash</param>
        /// <param name="marketableSecurities">Marketable Securities</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns>Decimal value for Cash Ratio</returns>
        public static decimal CalcCashRatio(decimal cash, decimal marketableSecurities, decimal currentLiabilities)
        {
            return (cash + marketableSecurities) / currentLiabilities;
        }

        /// <summary>
        /// Calculates Current Ratio from Current Assets and Current Liabilities
        /// </summary>
        /// <param name="currentAssets">Current Assets</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns>Decimal value for Current Ratio</returns>
        public static decimal CalcCurrentRatio(decimal currentAssets, decimal currentLiabilities)
        {
            return currentAssets / currentLiabilities;
        }

        /// <summary>
        /// Calculates Operating Cash Flow Ratio from Operating Cash Flow and Total Debts
        /// </summary>
        /// <param name="operatingCashFlow">Operating Cash Flow</param>
        /// <param name="totalDebts">Total Debts</param>
        /// <returns>Decimal value for Operating Cash Flow Ratio</returns>
        public static decimal CalcOperatingCashFlowRatio(decimal operatingCashFlow, decimal totalDebts)
        {
            return operatingCashFlow / totalDebts;
        }

        /// <summary>
        /// Calculates Quick Ratio from Current Assets, Inventories and Current Liabilities
        /// </summary>
        /// <param name="currentAssets">Current Assets</param>
        /// <param name="inventories">Inventories</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns>Decimal value for Quick Ratio</returns>
        public static decimal CalcQuickRatio(decimal currentAssets, decimal inventories, decimal currentLiabilities)
        {
            return (currentAssets - inventories) / currentLiabilities;
        }


        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Market                                                          |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Dividend Cover from Earnings Per Share and Dividends Per Share
        /// </summary>
        /// <param name="earningsPerShare">Earnings Per Share</param>
        /// <param name="dividendsPerShare">Dividends Per Share</param>
        /// <returns>Decimal value for Dividend Cover</returns>
        public static decimal CalcDividendCover(decimal earningsPerShare, decimal dividendsPerShare)
        {
            return earningsPerShare / dividendsPerShare;
        }

        /// <summary>
        /// Calculates Dividends Per Share (DPS) from Dividends Paid and Number Of Shares
        /// </summary>
        /// <param name="dividendsPaid">Dividends Paid</param>
        /// <param name="numberOfShares">Number of Shares</param>
        /// <returns>Decimal value for Dividends Per Share</returns>
        public static decimal CalcDividendsPerShare(decimal dividendsPaid, decimal numberOfShares)
        {
            return dividendsPaid / numberOfShares;
        }

        /// <summary>
        /// Calculates Dividend Yield from Annual Dividend Per Share and Price Per Share
        /// </summary>
        /// <param name="annualDividendPerShare">Annual Dividend Per Share</param>
        /// <param name="pricePerShare">Price Per Share</param>
        /// <returns>Decimal value for Dividend Yield</returns>
        public static decimal CalcDividendYield(decimal annualDividendPerShare, decimal pricePerShare)
        {
            return annualDividendPerShare / pricePerShare;
        }

        /// <summary>
        /// Calculates Earnings Per Share from Net Earnings and Number of Shares
        /// </summary>
        /// <param name="netEarnings">Net Earnings</param>
        /// <param name="numberOfShares">Number of Shares</param>
        /// <returns>Decimal value for Earnings Per Share</returns>
        public static decimal CalcEarningsPerShare(decimal netEarnings, decimal numberOfShares)
        {
            return netEarnings / numberOfShares;
        }

        /// <summary>
        /// Calculates Payout Ratio from Dividends and Earnings
        /// </summary>
        /// <param name="dividends">Dividends</param>
        /// <param name="earnings">Earnings</param>
        /// <returns>Decimal value for Payout Ratio</returns>
        public static decimal CalcPayoutRatio(decimal dividends, decimal earnings)
        {
            return dividends / earnings;
        }

        /// <summary>
        /// Calculates Price/Earnings to Growth (PEG) Ratio from Price Per Earnings and Annual EPS Growth
        /// </summary>
        /// <param name="pricePerEarnings">Price Per Earnings</param>
        /// <param name="annualEpsGrowth">Annual EPS Growth</param>
        /// <returns>Decimal value for PEG Ratio</returns>
        public static decimal CalcPegRatio(decimal pricePerEarnings, decimal annualEpsGrowth)
        {
            return pricePerEarnings / annualEpsGrowth;
        }

        /// <summary>
        /// Calculates Price to Sales Ratio from Price Per Share and Revenue Per Share
        /// </summary>
        /// <param name="pricePerShare">Price Per Share</param>
        /// <param name="revenuePerShare">Revenue Per Share</param>
        /// <returns>Decimal value for Price to Sales Ratio</returns>
        public static decimal CalcPriceSalesRatio(decimal pricePerShare, decimal revenuePerShare)
        {
            return pricePerShare / revenuePerShare;
        }

        /*
         * -----------------------------------------------------------------------------
         * | Formulas - Profitability                                                  |
         * -----------------------------------------------------------------------------
         */

        /// <summary>
        /// Calculates Efficiency Ratio from Non-Interest Expense and Revenue
        /// </summary>
        /// <param name="nonInterestExpense">Non-Interest Expense</param>
        /// <param name="revenue">Revenue</param>
        /// <returns>Decimal value for Efficiency Ratio</returns>
        public static decimal CalcEfficiencyRatio(decimal nonInterestExpense, decimal revenue)
        {
            return nonInterestExpense / revenue;
        }

        /// <summary>
        /// Calculates Gross Profit Margin from Gross Profit and Revenue
        /// </summary>
        /// <param name="grossProfit">Gross Profit</param>
        /// <param name="revenue">Revenue</param>
        /// <returns>Decimal value for Gross Profit Margin</returns>
        public static decimal CalcGrossProfitMargin(decimal grossProfit, decimal revenue)
        {
            return grossProfit / revenue;
        }

        /// <summary>
        /// Calculates Operating Margin from Operating Income and Revenue
        /// </summary>
        /// <param name="operatingIncome">Operating Income</param>
        /// <param name="revenue">Revenue</param>
        /// <returns>Decimal value for Operating Margin</returns>
        public static decimal CalcOperatingMargin(decimal operatingIncome, decimal revenue)
        {
            return operatingIncome / revenue;
        }

        /// <summary>
        /// Calculates Profit Margin from Net Profit and Revenue
        /// </summary>
        /// <param name="netProfit">Net Profit</param>
        /// <param name="revenue">Revenue</param>
        /// <returns>Decimal value for Profit Margin</returns>
        public static decimal CalcProfitMargin(decimal netProfit, decimal revenue)
        {
            return netProfit / revenue;
        }

        /// <summary>
        /// Calculates Return On Assets (ROA) from Net Income and Total Assets
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="totalAssets">Total Assets</param>
        /// <returns>Decimal value for Return On Assets</returns>
        public static decimal CalcReturnOnAssets(decimal netIncome, decimal totalAssets)
        {
            return netIncome / totalAssets;
        }

        /// <summary>
        /// Calculates Return On Capital (ROC) from EBIT, Tax Rate and Invested Capital
        /// </summary>
        /// <param name="ebit">Earnings Before Interest and Taxes</param>
        /// <param name="taxRate">Tax Rate</param>
        /// <param name="investedCapital">Invested Capital</param>
        /// <returns>Decimal value for Return On Capital</returns>
        public static decimal CalcReturnOnCapital(decimal ebit, decimal taxRate, decimal investedCapital)
        {
            return ebit * (1 - taxRate) / investedCapital;
        }

        /// <summary>
        /// Calculates Return on Equity (ROE) from Net Income and Average Shareholder Equity
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="averageShareholderEquity">Average Shareholder Equity</param>
        /// <returns>Decimal value for Return On Equity</returns>
        public static decimal CalcReturnOnEquity(decimal netIncome, decimal averageShareholderEquity)
        {
            return netIncome / averageShareholderEquity;
        }

        /// <summary>
        /// Calculates Return On Net Assets (RONA) from Net Income, Fixed Assets and Working Capital
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="fixedAssets">Fixed Assets</param>
        /// <param name="workingCapital">Working Capital</param>
        /// <returns>Decimal value for Return On Net Assets</returns>
        public static decimal CalcReturnOnNetAssets(decimal netIncome, decimal fixedAssets, decimal workingCapital)
        {
            return netIncome / (fixedAssets + workingCapital);
        }

        /// <summary>
        /// Calculates Risk-Adjusted Return On Capital (RAROC) from Expected Return and Economic Capital
        /// </summary>
        /// <param name="expectedReturn">Expected Return</param>
        /// <param name="economicCapital">Economic Capital</param>
        /// <returns>Decimal value for Risk Adjusted Return On Capital</returns>
        public static decimal CalcRiskAdjustedReturnOnCapital(decimal expectedReturn, decimal economicCapital)
        {
            return expectedReturn / economicCapital;
        }

        /// <summary>
        /// Calculates Return on Investment (ROI) from Gain and Cost
        /// </summary>
        /// <param name="gain">Gain</param>
        /// <param name="cost">Cost</param>
        /// <returns>Decimal value for Return On Investment</returns>
        public static decimal CalcReturnOnInvestment(decimal gain, decimal cost)
        {
            return (gain - cost) / cost;
        }

        /// <summary>
        /// Calculates Earnings Before Interest, Taxes, Depreciation and Amortization (EBITDA) from EBIT, Depreciation and Amortization
        /// </summary>
        /// <param name="ebit">Earnings Before Interest and Taxes</param>
        /// <param name="depreciation">Depreciation</param>
        /// <param name="amortization">Amortization</param>
        /// <returns>Decimal value for EBITDA</returns>
        public static decimal CalcEbitda(decimal ebit, decimal depreciation, decimal amortization)
        {
            return ebit + depreciation + amortization;
        }
    }
}
