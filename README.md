# Financial-Formulas-Library-.NET-Standard 

[![Build status](https://ci.appveyor.com/api/projects/status/iy080gvd0x4gmt3c?svg=true)](https://ci.appveyor.com/project/srbrettle/financial-formulas-api-net-standard) [![Build Status](https://travis-ci.org/srbrettle/Financial-Formulas-Library-.NET-Standard.svg?branch=master)](https://travis-ci.org/srbrettle/Financial-Formulas-Library-.NET-Standard) [![codecov](https://codecov.io/gh/srbrettle/Financial-Formulas-Library-.NET-Standard/branch/master/graph/badge.svg)](https://codecov.io/gh/srbrettle/Financial-Formulas-Library-.NET-Standard)
 [![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/srbrettle/Financial-Formulas-Library-.NET-Standard/issues)

A collection of methods for solving Finance/Accounting equations, implemented in C#. 
Java, Python and C++ implementations are available [here](https://github.com/srbrettle/Financial-Formulas).

## Getting Started - C#

### Using NuGet [![NuGet](https://img.shields.io/badge/NuGet-1.3.1-blue.svg)](https://www.nuget.org/packages/FinancialFormulas/1.3.1)

1. Within your project, install FinancialFormulas NuGet package (via "Manage Packages for Solution" or running the following in "Packet Manager Console".
```PowerShell
Install-Package FinancialFormulas -Version 1.3.1
```
2. Reference the Namespace:
```c#
using srbrettle.FinancialFormulas;
```
3. Use the static library methods:
```c#
double result = FinancialFormulas.CalcPriceSalesRatio(500,200);
```

### Manually

1. Download and import [this](/FinancialFormulas/) library into your project.
2. Reference the Namespace:
```c#
using srbrettle.FinancialFormulas;
```
3. Use the static library methods:
```c#
double result = FinancialFormulas.CalcPriceSalesRatio(500,200);
```

## License

This project is licensed under the MIT License - see the [LICENSE](/LICENSE) file for details.

## Formulas / Equations included
### FinancialFormulas.cs
* Asset Turnover
* Assets
* Average Collection Period
* Book Value
* Cash Conversion Cycle
* Cash Ratio
* Current Ratio
* Debt Equity Ratio
* Debt Ratio
* Debt Service Coverage Ratio
* Declining Balance
* Dividend Cover
* Dividend Yield
* Dividends Per Share
* Earnings Per Share
* EBIT
* EBITDA
* Efficiency Ratio
* Equity
* Gross Profit
* Gross Profit Margin
* Inventory Conversion Period
* Inventory Conversion Ratio
* Inventory Turnover
* Long-Term Debt Equity Ratio
* Liabilities
* Net Profit
* Operating Cash Flow Ratio
* Operating Margin
* Operating Profit
* Payables Conversion Period
* Payout Ratio
* PEG Ratio
* Price Sales Ratio
* Profit Margin
* Quick Ratio
* Receivables Conversion Period
* Receivables Turnover Ratio
* Return On Assets
* Return On Capital
* Return On Equity
* Return On Investment
* Return On Net Assets
* Risk Adjusted Return On Capital
* Sales Revenue
* Straight Line Method
* Units Of Production
### BankingFormulas.cs
* Annual Percentage Yield
* Balloon Loan Payment
* Compound Interest
* Continuous Compounding
* Debt To Income Ratio
* Balloon Balance Of Loan
* Loan Payment
* Remaining Balance On Loan
* Loan To Deposit Ratio
* Loan To Value Ratio
* Simple Interest
* Simple Interest Rate
* Simple Interest Principal
* Simple Interest Time
### FinancialMarketsFormulas.cs
* Rate Of Inflation
* Real Rate Of Return
### StocksBondsFormulas.cs
* Bid Ask Spread
* Bond Equivalent Yield
* Book Value per Share
* Capital Asset Pricing Model
* Capital Gains Yield
* Current Yield
* Diluted Earnings Per Share
* Dividend Payout Ratio
* Dividend Yield - Stock
* Dividends Per Share
* Earnings Per Share
* Equity Multiplier
* Estimated Earnings
* Geometric Mean Return
* Holding Period Return
* Net Asset Value
* Preferred Stock
* Price to Book Value
* Price to Earnings (P/E Ratio)
* Price to Sales (P/S Ratio)
* Risk Premium
* Stock - PV with Constant Growth
* Stock - PV with Zero Growth
* Tax Equivalent Yield
* Total Stock Return
* Yield to Maturity
* Zero Coupon Bond Value
* Zero Coupon Bond Yield
### CorporateFormulas.cs
* Asset to Sales Ratio
* Asset Turnover Ratio
* Avg Collection Period
* Contribution Margin
* Current Ratio
* Days in Inventory
* Debt Coverage Ratio
* Debt Ratio
* Debt to Equity Ratio
* Discounted Payback Period
* Equivalent Annual Annuity
* Free Cash Flow to Equity (FCFE)
* Free Cash Flow to Firm (FCFF)
* Interest Coverage Ratio
* Inventory Turnover Ratio
* Net Present Value
* Net Profit Margin
* Net Working Capital
* Payback Period
* Quick Ratio
* Receivables Turnover Ratio
* Retention Ratio
* Return on Assets (ROA)
* Return on Equity (ROE)
* Return on Investment
### GeneralFinanceFormulas.cs
* Annuity - Future Value
* Annuity - Future Value w/ Continuous Compounding
* Annuity - (FV) Solve for n
* Annuity - Payment (PV)
* Annuity - Payment (FV)
* Annuity - (PV) Solve for n
* Annuity - Present Value
* Avg Collection Period
* Annuity - PV Factor
* Annuity Due - Present Value
* Annuity Due - Future Value
* Annuity Due Payment (PV)
* Annuity Due Payment (FV)
* Doubling Time
* Doubling Time - Cont. Compounding
* Doubling Time - Simple Interest
* Future Value
* FV - Continuous Compounding
* Future Value Factor
* Growing Annuity - Future Value
* Growing Annuity - Payment (PV)
* Growing Annuity - Payment (FV)
* Growing Annuity - Present Value
* Growing Perpetuity - Present Value
* Number of Periods - PV & FV
* Perpetuity
* Present Value
* PV - Continuous Compounding
* Present Value Factor
* Rule of 72
* Weighted Average
