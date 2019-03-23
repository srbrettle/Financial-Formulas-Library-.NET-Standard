using System;
using System.Collections;

namespace srbrettle.FinancialFormulas
{
    /// <summary>
    /// A collection of methods for solving Corporate Finance/Accounting equations.
    /// </summary>
    public static class CorporateFormulas
    {
        /// <summary>
        /// Calculates Asset to Sales Ratio from Total Assets and Sales Revenue
        /// </summary>
        /// <param name="totalAssets">Total Assets</param>
        /// <param name="salesRevenue">Sales Revenue</param>
        /// <returns>Decimal value for Asset to Sales Ratio</returns>
        public static decimal CalcAssetToSalesRatio(decimal totalAssets, decimal salesRevenue)
        {
            return totalAssets / salesRevenue;
        }

        /// <summary>
        /// Calculates Asset Turnover Ratio from Sales Revenue and Total Assets
        /// </summary>
        /// <param name="salesRevenue">Sales Revenue</param>
        /// <param name="totalAssets">Total Assets</param>
        /// <returns>Decimal value for Asset Turnover Ratio</returns>
        public static decimal CalcAssetTurnoverRatio(decimal salesRevenue, decimal totalAssets)
        {
            return salesRevenue / totalAssets;
        }

        /// <summary>
        /// Calculates Average Collection Period from Receivables Turnover
        /// </summary>
        /// <param name="receivablesTurnover">Receivables Turnover</param>
        /// <returns>Decimal value for Average Collection Period</returns>
        public static decimal CalcAverageCollectionPeriod(decimal receivablesTurnover)
        {
            return 365 / receivablesTurnover;
        }

        /// <summary>
        /// Calculates Contribution Margin from Price per Product and Variable Cost per Product
        /// </summary>
        /// <param name="pricePerProduct">Price per Product</param>
        /// <param name="variableCostPerProduct">Variable Cost Per Product</param>
        /// <returns>Decimal value for Contribution Margin</returns>
        public static decimal CalcContributionMargin(decimal pricePerProduct, decimal variableCostPerProduct)
        {
            return pricePerProduct - variableCostPerProduct;
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
        /// Calculates Days In Inventory from Inventory Turnover
        /// </summary>
        /// <param name="inventoryTurnover">Inventory Turnover</param>
        /// <returns>Decimal value for Days In Inventory</returns>
        public static decimal CalcDaysInInventory(decimal inventoryTurnover)
        {
            return 365 / inventoryTurnover;
        }

        /// <summary>
        /// Calculates Debt Coverage Ratio from Net Operating Income and Debt Service
        /// </summary>
        /// <param name="netOperatingIncome">Net Operating Income</param>
        /// <param name="debtService">Debt Service</param>
        /// <returns>Decimal value for Debt Coverage Ratio</returns>
        public static decimal CalcDebtCoverageRatio(decimal netOperatingIncome, decimal debtService)
        {
            return netOperatingIncome / debtService;
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
        /// Calculates Debt to Equity Ratio from Total Liabilities and Total Equity
        /// </summary>
        /// <param name="totalLiabilities">Total Liabilities</param>
        /// <param name="totalEquity">Total Equity</param>
        /// <returns>Decimal value for Debt to Equity Ratio</returns>
        public static decimal CalcDebtToEquityRatio(decimal totalLiabilities, decimal totalEquity)
        {
            return totalLiabilities / totalEquity;
        }

        /// <summary>
        /// Calculates Discounted Payback Period from Initial Investment, Rate and Periodic Cash Flow
        /// </summary>
        /// <param name="initialInvestment">Initial Investment</param>
        /// <param name="rate">Rate</param>
        /// <param name="periodicCashFlow">Periodic Cash Flow</param>
        /// <returns>Decimal value for Discounted Payback Period</returns>
        public static decimal CalcDiscountedPaybackPeriod(decimal initialInvestment, decimal rate, decimal periodicCashFlow)
        {
            return ((decimal)Math.Log(1 / (1 - (((double)initialInvestment * (double)rate) / (double)periodicCashFlow)))) / ((decimal)Math.Log(1 + (double)rate));
        }

        /// <summary>
        /// Calculates for Equivalent Annual Annuity from Equivalent Annuity Cash Flow, Net Present Value, Rate per Period and Number of Periods
        /// </summary>
        /// <param name="netPresentValue">Net Present Value</param>
        /// <param name="ratePerPeriod">Rate per Period</param>
        /// <param name="numberOfPeriods">Number of Periods</param>
        /// <returns>Decimal value for Equivalent Annual Annuity</returns>
        public static decimal CalcEquivalentAnnualAnnuity(decimal netPresentValue, decimal ratePerPeriod, decimal numberOfPeriods)
        {
            return (ratePerPeriod * netPresentValue) / (1 - (decimal)Math.Pow(1 + (double)ratePerPeriod, (double)-numberOfPeriods));
        }

        /// <summary>
        /// Calculates Free Cash Flow to Equity from Net Income, Depreciation and Amortization, Capital Expenditures, Change in Working Capital and Net Borrowing
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="depreciationAndAmortization">Depreciation and Amortization</param>
        /// <param name="capitalExpenditure">Capital Expenditures</param>
        /// <param name="changeInWorkingCapital">Change in Working Capital</param>
        /// <param name="netBorrowing">Net Borrowing</param>
        /// <returns>Decimal value for Free Cash Flow to Equity</returns>
        public static decimal CalcFreeCashFlowToEquity(decimal netIncome, decimal depreciationAndAmortization, decimal capitalExpenditure, decimal changeInWorkingCapital, decimal netBorrowing)
        {
            return netIncome + depreciationAndAmortization - changeInWorkingCapital - capitalExpenditure + netBorrowing;
        }

        /// <summary>
        /// Calculates Free Cash Flow to Firm from EBIT, Tax rate, Depreciation and Amortization, Capital Expenditures and Change in Working Capital
        /// </summary>
        /// <param name="ebit">EBIT</param>
        /// <param name="taxRate">Tax Rate</param>
        /// <param name="depreciationAndAmortization">Depreciation and Amortization</param>
        /// <param name="capitalExpenditure">Capital Expenditures</param>
        /// <param name="changeInWorkingCapital">Change in Working Capital</param>
        /// <returns>Decimal value for Free Cash Flow to Firm</returns>
        public static decimal CalcFreeCashFlowToFirm(decimal ebit, decimal taxRate, decimal depreciationAndAmortization, decimal capitalExpenditure, decimal changeInWorkingCapital)
        {
            return ebit * (1 - taxRate) + depreciationAndAmortization - capitalExpenditure - changeInWorkingCapital;
        }

        /// <summary>
        /// Calculates Interest Coverage Ratio from EBIT and Interest Expense
        /// </summary>
        /// <param name="ebit">EBIT</param>
        /// <param name="interestExpense">Interest Expense</param>
        /// <returns>Decimal value for Interest Coverage Ratio</returns>
        public static decimal CalcInterestCoverageRatio(decimal ebit, decimal interestExpense)
        {
            return ebit / interestExpense;
        }

        /// <summary>
        /// Calculates Inventory Turnover Ratio from Sales and Inventory
        /// </summary>
        /// <param name="sales">Sales</param>
        /// <param name="inventory">Inventory</param>
        /// <returns>Decimal value for Inventory Turnover Ratio</returns>
        public static decimal CalcInventoryTurnoverRatio(decimal sales, decimal inventory)
        {
            return sales / inventory;
        }

        /// <summary>
        /// Calculates Net Present Value from Initial Investment, Cash Flows and Discount Rate
        /// </summary>
        /// <param name="initialInvestment">Initial Investment</param>
        /// <param name="cashFlows">Cash Flows</param>
        /// <param name="discountRate">Discount Rate</param>
        /// <returns>Decimal value for Net Present Value</returns>
        public static decimal CalcNetPresentValue(decimal initialInvestment, ICollection cashFlows, decimal discountRate)
        {
            decimal sumTotal = 0;
            int count = 1;
            foreach (decimal cashFlowAtPeriod in cashFlows)
            {
                sumTotal += cashFlowAtPeriod / (decimal)Math.Pow((double)(1 + discountRate), count);
                count++;
            }            

            return -initialInvestment + sumTotal;
        }

        /// <summary>
        /// Calculates Net Profit Margin from Net Income and Sales Revenue
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="salesRevenue">Sales Revenue</param>
        /// <returns>Decimal value for Net Profit Margin</returns>
        public static decimal CalcNetProfitMargin(decimal netIncome, decimal salesRevenue)
        {
            return netIncome / salesRevenue;
        }

        /// <summary>
        /// Calculates Net Working Capital from Current Assets and Current Liabilities
        /// </summary>
        /// <param name="currentAssets">Current Assets</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns>Decimal value for Net Working Capital</returns>
        public static decimal CalcNetWorkingCapital(decimal currentAssets, decimal currentLiabilities)
        {
            return currentAssets - currentLiabilities;
        }

        /// <summary>
        /// Calculates Payback Period from Initial Investment and Periodic Cash Flow
        /// </summary>
        /// <param name="initialInvestment">Initial Investment</param>
        /// <param name="periodicCashFlow">Periodic Cash Flow</param>
        /// <returns>Decimal value for Payback Period</returns>
        public static decimal CalcPaybackPeriod(decimal initialInvestment, decimal periodicCashFlow)
        {
            return initialInvestment / periodicCashFlow;
        }

        /// <summary>
        /// Calculates Quick Ratio from Quick Assets and Current Liabilities
        /// </summary>
        /// <param name="quickAssets">Quick Assets</param>
        /// <param name="currentLiabilities">Current Liabilities</param>
        /// <returns>Decimal value for Quick Ratio</returns>
        public static decimal CalcQuickRatio(decimal quickAssets, decimal currentLiabilities)
        {
            return quickAssets / currentLiabilities;
        }

        /// <summary>
        /// Calculates Receivables Turnover Ratio from Sales Revenue and Average Accounts Receivable
        /// </summary>
        /// <param name="salesRevenue">Sales Revenue</param>
        /// <param name="averageAccountsReceivable">Average Accounts Receivable</param>
        /// <returns>Decimal value for Receivables Turnover Ratio</returns>
        public static decimal CalcReceivablesTurnoverRatio(decimal salesRevenue, decimal averageAccountsReceivable)
        {
            return salesRevenue / averageAccountsReceivable;
        }

        /// <summary>
        /// Calculates Retention Ratio from Net Income and Dividends
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="dividends">Dividends</param>
        /// <returns>Decimal value for Retention Ratio</returns>
        public static decimal CalcRetentionRatio(decimal netIncome, decimal dividends)
        {
            return (netIncome - dividends) / netIncome;
        }

        /// <summary>
        /// Calculates Return on Assets from Net Income and Average Total Assets
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="averageTotalAssets">Average Total Assets</param>
        /// <returns>Decimal value for Return on Assets</returns>
        public static decimal CalcReturnOnAssets(decimal netIncome, decimal averageTotalAssets)
        {
            return netIncome / averageTotalAssets;
        }

        /// <summary>
        /// Calculates Return on Equity from Net Income and Average Stockholders Equity
        /// </summary>
        /// <param name="netIncome">Net Income</param>
        /// <param name="averageStockholdersEquity">Average Stockholders Equity</param>
        /// <returns>Decimal value for Return on Equity</returns>
        public static decimal CalcReturnOnEquity(decimal netIncome, decimal averageStockholdersEquity)
        {
            return netIncome / averageStockholdersEquity;
        }

        /// <summary>
        /// Calculates Return on Investment from Earnings and Initial Investment
        /// </summary>
        /// <param name="earnings">Earnings</param>
        /// <param name="initialInvestment">Initial Investment</param>
        /// <returns>Decimal value for Return on Investment</returns>
        public static decimal CalcReturnOnInvestment(decimal earnings, decimal initialInvestment)
        {
            return (earnings - initialInvestment) / initialInvestment;
        }
    }
}
