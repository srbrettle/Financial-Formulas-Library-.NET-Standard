node {
	stage 'Checkout'
		checkout scm

	stage 'Build Restore'
		bat 'dotnet restore FinancialFormulas.sln'
 		
	stage 'Build Release NetCore'
		bat "dotnet build FinancialFormulas/FinancialFormulas.csproj --configuration Release"
		
	stage 'Build Debug NetCore'
		bat "dotnet build FinancialFormulas/FinancialFormulas.csproj --configuration Debug"

	stage 'Archive'
		archive 'FinancialFormulas/bin/Release/**'

}
