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
        /// <returns></returns>
        public static double CalcAssetTurnover(double netSales, double totalAssets)
        {
            return netSales / totalAssets;
        }

        /// <summary>
        /// Calculates Average Collection Period from Accounts Receivable and Annual Credit Sales
        /// </summary>
        /// <param name="accountsReceivable">Accounts Receivable</param>
        /// <param name="annualCreditSales">Annual Credit Sales</param>
        /// <returns></returns>
        public static double CalcAverageCollectionPeriod(double accountsReceivable, double annualCreditSales)
        {
            return accountsReceivable / (annualCreditSales / 365);
        }

        /// <summary>
        /// Calcualtes Cash Conversion Cycle from Inventory Conversion Period, Receivables Conversion Period and Payables Conversion Period
        /// </summary>
        /// <param name="inventoryConversionPeriod">Inventory Conversion Period</param>
        /// <param name="receivablesConversionPeriod">Receivables Conversion Period</param>
        /// <param name="payablesConversionPeriod">Payables Conversion Period</param>
        /// <returns></returns>
        public static double CalcCashConversionCycle(double inventoryConversionPeriod, double receivablesConversionPeriod, double payablesConversionPeriod)
        {
            return (inventoryConversionPeriod
                    + receivablesConversionPeriod - payablesConversionPeriod);
        }

        /// <summary>
        /// Calculates Inventory Conversion Period from Inventory Turnover Ratio
        /// </summary>
        /// <param name="inventoryTurnoverRatio">Inventory Turnover Ratio</param>
        /// <returns></returns>
        public static double CalcInventoryConversionPeriod(double inventoryTurnoverRatio)
        {
            return 365 / inventoryTurnoverRatio;
        }

        /// <summary>
        /// Calculates Inventory Conversion Ratio from Sales and Cost Of Goods Sold
        /// </summary>
        /// <param name="sales">Sales</param>
        /// <param name="costOfGoodsSold">Cost Of Goods Sold</param>
        /// <returns></returns>
        public static double CalcInventoryConversionRatio(double sales, double costOfGoodsSold)
        {
            return (sales * 0.5) / costOfGoodsSold;
        }

        /// <summary>
        /// Calculates Inventory Turnover from Sales and Average Inventory
        /// </summary>
        /// <param name="sales">Sales</param>
        /// <param name="averageInventory">Average Inventory</param>
        /// <returns></returns>
        public static double CalcInventoryTurnover(double sales, double averageInventory)
        {
            return sales / averageInventory;
        }

        /// <summary>
        /// Calculates Payables Conversion Period from Accounts Payable and Purchases
        /// </summary>
        /// <param name="accountsPayable">Accounts Payable</param>
        /// <param name="purchases">Purchases</param>
        /// <returns></returns>
        public static double CalcPayablesConversionPeriod(double accountsPayable, double purchases)
        {
            return (accountsPayable / purchases) * 365;
        }

        /// <summary>
        /// Calculates Receivables Conversion Period from Receivables and Net Sales
        /// </summary>
        /// <param name="receivables">Receivables</param>
        /// <param name="netSales">Net Sales</param>
        /// <returns></returns>
        public static double CalcReceivablesConversionPeriod(double receivables, double netSales)
        {
            return (receivables / netSales) * 365;
        }

        /// <summary>
        /// Calculates Receivables Turnover Ratio from Net Credit Sales and Average Net Receivables
        /// </summary>
        /// <param name="netCreditSales">Net Credit Sales</param>
        /// <param name="averageNetReceivables">Average Net Receivables</param>
        /// <returns></returns>
        public static double CalcReceivablesTurnoverRatio(double netCreditSales, double averageNetReceivables)
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
        /// <returns></returns>
        public static double CalcAssets(double liabilities, double equity)
        {
            return liabilities + equity;
        }

        /// <summary>
        /// Calculates Earnings Before Interest and Taxes (EBIT) from Revenue and Operating Expenses
        /// </summary>
        /// <param name="revenue">Revenue</param>
        /// <param name="operatingExpenses">Operating Expenses</param>
        /// <returns></returns>
        public static double CalcEbit(double revenue, double operatingExpenses)
        {
            return revenue - operatingExpenses;
        }

        /// <summary>
        /// Calculates Equity from Assets and Liabilities
        /// </summary>
        /// <param name="assets">Assets</param>
        /// <param name="liabilities">Liabilities</param>
        /// <returns></returns>
        public static double CalcEquity(double assets, double liabilities)
        {
            return assets - liabilities;
        }

        /// <summary>
        /// Calculates Gross Profit from Revenue and Cost Of Goods Sold (COGS)
        /// </summary>
        /// <param name="revenue">Revenue</param>
        /// <param name="costOfGoodsSold">Cost Of Goods Sold</param>
        /// <returns></returns>
        public static double CalcGrossProfit(double revenue, double costOfGoodsSold)
        {
            return revenue - costOfGoodsSold;
        }

        /// <summary>
        /// Calculates Liabilities from Assets and Equity
        /// </summary>
        /// <param name="assets">Assets</param>
        /// <param name="equity">Equity</param>
        /// <returns></returns>
        public static double CalcLiabilities(double assets, double equity)
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
        /// <returns></returns>
        public static double CalcNetProfit(double grossProfit, double operatingExpenses, double taxes, double interest)
        {
            return grossProfit - operatingExpenses - taxes - interest;
        }

        /// <summary>
        /// Calculates Operation Profit from Gross Profit and Operating Expenses
        /// </summary>
        /// <param name="grossProfit">Gross Profit</param>
        /// <param name="operatingExpenses">Operating Expenses</param>
        /// <returns></returns>
        public static double CalcOperatingProfit(double grossProfit, double operatingExpenses)
        {
            return grossProfit - operatingExpenses;
        }

        /// <summary>
        /// Calculates Sales Revenue from Gross Sales and Sales of Returns and Allowances
        /// </summary>
        /// <param name="grossSales">Gross Sales</param>
        /// <param name="salesOfReturnsAndAllowances">Sales of Returns and Allowances</param>
        /// <returns></returns>
        public static double CalcSalesRevenue(double grossSales, double salesOfReturnsAndAllowances)
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
        /// <returns></returns>
        public static double CalcDebtEquityRatio(double totalLiabilities, double shareholderEquity)
        {
            return totalLiabilities / shareholderEquity;
        }

        /// <summary>
        /// Calculates Debt Ratio Total Liabilities and Total Assets
        /// </summary>
        /// <param name="totalLiabilities">Total Liabilities</param>
        /// <param name="totalAssets">Total Assets</param>
        /// <returns></returns>
        public static double CalcDebtRatio(double totalLiabilities, double totalAssets)
        {
            return totalLiabilities / totalAssets;
        }

        /// <summary>
        /// Calculates Debt-Service Coverage Ratio Net Operating Income and Total Debt Service
        /// </summary>
        /// <param name="netOperatingIncome">Net Operating Income</param>
        /// <param name="totalDebtService">Total Debt Service</param>
        /// <returns></returns>
        public static double CalcDebtServiceCoverageRatio(double netOperatingIncome, double totalDebtService)
        {
            return netOperatingIncome / totalDebtService;
        }

        /// <summary>
        /// Calculates Long-Term Debt to Equity Ratio from Long-Term Liabilities and Equity
        /// </summary>
        /// <param name="longTermLiabilities">Long-Term Liabilities</param>
        /// <param name="equity">Equity</param>
        /// <returns></returns>
        public static double CalcLongTermDebtEquityRatio(double longTermLiabilities, double equity)
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
        /// <returns></returns>
        public static double CalcBookValue(double acquisitionCost, double depreciation)
        {
            return acquisitionCost - depreciation;
        }

        /// <summary>
        /// Calculates Decling Balance from Depreciation Rate and Book Value at Beginning of Year
        /// </summary>
        /// <param name="depreciationRate">Depreciation Rate</param>
        /// <param name="bookValueAtBeginningOfYear">Book Value at Beginning of Year</param>
        /// <returns></returns>
        public static double CalcDecliningBalance(double depreciationRate, double bookValueAtBeginningOfYear)
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
        /// <returns></returns>
        public static double CalcUnitsOfProduction(double costOfAsset, double residualValue, double estimatedTotalProduction, double actualProduction)
        {
            return ((costOfAsset - residualValue) / estimatedTotalProduction) * actualProduction;
        }

        /// <summary>
        /// Calculates Straight Line Method from Cost of Fixed Asset, Residual Value and Useful Life of Asset
        /// </summary>
        /// <param name="costOfFixedAsset">Cost of Fixed Asset</param>
        /// <param name="residualValue">Residual Value</param>
        /// <param name="usefulLifeOfAsset">Useful Life of Asset</param>
        /// <returns></returns>
        public static double CalcStraightLineMethod(double costOfFixedAsset, double residualValue, double usefulLifeOfAsset)
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
        /// <returns></returns>
        public static double CalcCashRatio(double cash, double marketableSecurities, double currentLiabilities)
        {
            return (cash + marketableSecurities) / currentLiabilities;
        }

        /// <summary>
        /// Calculates Current Ratio from Current Assets and Current Liabilties
        /// </summary>
        /// <param name="currentAssets">Current Assets</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns></returns>
        public static double CalcCurrentRatio(double currentAssets, double currentLiabilities)
        {
            return currentAssets / currentLiabilities;
        }

        /// <summary>
        /// Calculates Operating Cash Flow Ratio from Operating Cash Flow and Total Debts
        /// </summary>
        /// <param name="operatingCashFlow">Operating Cash Flow</param>
        /// <param name="totalDebts">Total Debts</param>
        /// <returns></returns>
        public static double CalcOperatingCashFlowRatio(double operatingCashFlow, double totalDebts)
        {
            return operatingCashFlow / totalDebts;
        }

        /// <summary>
        /// Calculates Quick Ratio from Current Assets, Inventories and Current Liabilities
        /// </summary>
        /// <param name="currentAssets">Current Assets</param>
        /// <param name="inventories">Inventories</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns></returns>
        public static double CalcQuickRatio(double currentAssets, double inventories, double currentLiabilities)
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
        /// <param name="dividendsPerShare">Devidends Per Share</param>
        /// <returns></returns>
        public static double CalcDividendCover(double earningsPerShare, double dividendsPerShare)
        {
            return earningsPerShare / dividendsPerShare;
        }

        /// <summary>
        /// Calculates Dividends Per Share (DPS) from Dividends Paid and Number Of Shares
        /// </summary>
        /// <param name="dividendsPaid">Dividends Paid</param>
        /// <param name="numberOfShares">Number of Shares</param>
        /// <returns></returns>
        public static double CalcDividendsPerShare(double dividendsPaid, double numberOfShares)
        {
            return dividendsPaid / numberOfShares;
        }

        /// <summary>
        /// Calculates Dividend Yield from Annual Dividend Per Share and Price Per Share
        /// </summary>
        /// <param name="annualDividendPerShare">Annual Dividend Per Share</param>
        /// <param name="pricePerShare">Price Per Share</param>
        /// <returns></returns>
        public static double CalcDividendYield(double annualDividendPerShare, double pricePerShare)
        {
            return annualDividendPerShare / pricePerShare;
        }

        /// <summary>
        /// Calculates Earnings Per Share from Net Earnings and Number of Shares
        /// </summary>
        /// <param name="netEarnings">Net Earnings</param>
        /// <param name="numberOfShares">Number of Shares</param>
        /// <returns></returns>
        public static double CalcEarningsPerShare(double netEarnings, double numberOfShares)
        {
            return netEarnings / numberOfShares;
        }

        /// <summary>
        /// Calculates Payout Ratio from Dividends and Earnings
        /// </summary>
        /// <param name="dividends">Dividends</param>
        /// <param name="earnings">Earnings</param>
        /// <returns></returns>
        public static double CalcPayoutRatio(double dividends, double earnings)
        {
            return dividends / earnings;
        }

        /// <summary>
        /// Calculates Price/Earnings to Growth (PEG) Ratio from Price Per Earnings and Annual EPS Growth
        /// </summary>
        /// <param name="pricePerEarnings">Price Per Earnings</param>
        /// <param name="annualEpsGrowth">Annual EPS Growth</param>
        /// <returns></returns>
        public static double CalcPegRatio(double pricePerEarnings, double annualEpsGrowth)
        {
            return pricePerEarnings / annualEpsGrowth;
        }

        /// <summary>
        /// Calculates Price to Sales Ratio from Price Per Share and Revenue Per Share
        /// </summary>
        /// <param name="pricePerShare">Price Per Share</param>
        /// <param name="revenuePerShare">Revenue Per Share</param>
        /// <returns></returns>
        public static double CalcPriceSalesRatio(double pricePerShare, double revenuePerShare)
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
        /// <returns></returns>
        public static double CalcEfficiencyRatio(double nonInterestExpense, double revenue)
        {
            return nonInterestExpense / revenue;
        }

        /// <summary>
        /// Calculates Gross Profit Margin from Gross Profit and Revenue
        /// </summary>
        /// <param name="grossProfit">Gross Profit</param>
        /// <param name="revenue">Revenue</param>
        /// <returns></returns>
        public static double CalcGrossProfitMargin(double grossProfit, double revenue)
        {
            return grossProfit / revenue;
        }

        /// <summary>
        /// Calculates Operating Margin from Operating Income and Revenue
        /// </summary>
        /// <param name="operatingIncome">Operating Income</param>
        /// <param name="revenue">Revenue</param>
        /// <returns></returns>
        public static double CalcOperatingMargin(double operatingIncome, double revenue)
        {
            return operatingIncome / revenue;
        }

        /// <summary>
        /// Calculates Profit Margin from Net Profit and Revenue
        /// </summary>
        /// <param name="netProfit">Net Profit</param>
        /// <param name="revenue">Revenue</param>
        /// <returns></returns>
        public static double CalcProfitMargin(double netProfit, double revenue)
        {
            return netProfit / revenue;
        }

        /// <summary>
        /// Calculates Return On Assets (ROA) from Net Income and Total Assets
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="totalAssets">Total Assets</param>
        /// <returns></returns>
        public static double CalcReturnOnAssets(double netIncome, double totalAssets)
        {
            return netIncome / totalAssets;
        }

        /// <summary>
        /// Calculates Return On Capital (ROC) from EBIT, Tax Rate and Invested Capital
        /// </summary>
        /// <param name="ebit">Earnings Before Interest and Taxes</param>
        /// <param name="taxRate">Tax Rate</param>
        /// <param name="investedCapital">Invested Capital</param>
        /// <returns></returns>
        public static double CalcReturnOnCapital(double ebit, double taxRate, double investedCapital)
        {
            return ebit * (1 - taxRate) / investedCapital;
        }

        /// <summary>
        /// Calculates Return on Equity (ROE) from Net Income and Average Shareholder Equity
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="averageShareholderEquity">Average Shareholder Equity</param>
        /// <returns></returns>
        public static double CalcReturnOnEquity(double netIncome, double averageShareholderEquity)
        {
            return netIncome / averageShareholderEquity;
        }

        /// <summary>
        /// Calculates Return On Net Assets (RONA) from Net Income, Fixed Assets and Working Capital
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="fixedAssets">Fixed Assets</param>
        /// <param name="workingCapital">Working Capital</param>
        /// <returns></returns>
        public static double CalcReturnOnNetAssets(double netIncome, double fixedAssets, double workingCapital)
        {
            return netIncome / (fixedAssets + workingCapital);
        }

        /// <summary>
        /// Calculates Risk-Adjusted Return On Capital (RAROC) from Expected Return and Economic Capital
        /// </summary>
        /// <param name="expectedReturn">Expected Return</param>
        /// <param name="economicCapital">Economic Capital</param>
        /// <returns></returns>
        public static double CalcRiskAdjustedReturnOnCapital(double expectedReturn, double economicCapital)
        {
            return expectedReturn / economicCapital;
        }

        /// <summary>
        /// Calculates Return on Investment (ROI) from Gain and Cost
        /// </summary>
        /// <param name="gain">Gain</param>
        /// <param name="cost">Cost</param>
        /// <returns></returns>
        public static double CalcReturnOnInvestment(double gain, double cost)
        {
            return (gain - cost) / cost;
        }

        /// <summary>
        /// Calculates Earnings Before Interest, Taxes, Depreciation and Amortization (EBITDA) from EBIT, Depreciation and Amortization
        /// </summary>
        /// <param name="ebit">Earnings Before Interest and Taxes</param>
        /// <param name="depreciation">Depreciation</param>
        /// <param name="amortization">Amortization</param>
        /// <returns></returns>
        public static double CalcEbitda(double ebit, double depreciation, double amortization)
        {
            return ebit + depreciation + amortization;
        }
    }
}
