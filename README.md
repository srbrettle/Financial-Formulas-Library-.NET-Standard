# Financial-Formulas-API-.NET-Core [![Build Status](https://travis-ci.org/srbrettle/Financial-Formulas-API-.NET-Core.svg?branch=master)](https://travis-ci.org/srbrettle/Financial-Formulas-API-.NET-Core) [![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/srbrettle/Financial-Formulas-API-.NET-Core/issues)

A collection of methods for solving Finance/Accounting equations, implemented in C#. 
Java, Python and C++ implementations are available [here](https://github.com/srbrettle/Financial-Formulas).

## See in Action

[Finance Calculator - Android Application](https://play.google.com/store/apps/details?id=barwick.financecalculator)

## Getting Started - C#

### Using NuGet [![NuGet](https://img.shields.io/badge/NuGet-1.2.0-blue.svg)](https://www.nuget.org/packages/FinancialFormulas/1.2.0)

1. Within your project, install FinancialFormulas NuGet package (via "Manage Packages for Solution" or running the following in "Packet Manager Console".
```PowerShell
Install-Package FinancialFormulas -Version 1.2.0
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

1. Download and import [this](/main/csharp/) library into your project.
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
### FinancialMarketsFormulas.cs
* Rate Of Inflation
* Real Rate Of Return
