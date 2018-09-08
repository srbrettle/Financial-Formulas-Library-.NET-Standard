node {
	stage 'Checkout'
		checkout scm

	stage 'Restore'
		bat 'dotnet restore FinancialFormulas.sln'
 		
	stage 'Build Release NetCore'
		bat "dotnet build FinancialFormulas/FinancialFormulas.csproj --configuration Release"
		
	stage 'Build Debug NetCore'
		bat "dotnet build FinancialFormulas/FinancialFormulas.csproj --configuration Debug"
	
	stage 'Unit Tests'
		bat "dotnet test Test/UnitTest.FinancialFormulas.csproj --logger:trx"

	stage 'Archive'
		archive 'FinancialFormulas/bin/**/*'
}
