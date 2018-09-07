using srbrettle.FinancialFormulas;
using Xunit;

namespace UnitTest_FinancialFormulas
{
    public class UnitTest_FinancialMarketsFormulas {

        [Fact]
		public void UnitTest_CalcRateOfInflation()
        {
            var result = FinancialMarketsFormulas.CalcRateOfInflation(1000, 2000);
            Assert.Equal(1, result);
        }

        [Fact]
        public void UnitTest_CalcRealRateOfReturn()
        {
            var result = FinancialMarketsFormulas.CalcRealRateOfReturn(0.04m, 0.02m);
            Assert.Equal(0.0196078431372549019607843137m, result);
        }
    }
}