using DailyKata;

namespace KataTest
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_AddZeroIntoMethodMultiplyZeroUntilAnswerIsOnlyOneDigit_ShouldGiveZero()
        {
            Assert.Equal(0, Reducer.SumDigProd(0));
        }
        [Fact]
        public void Sum_GetTheSumAndSplitIntoMultiplyTheDigits_ShouldGiveOneDigit()
        {
            Assert.Equal(0, Reducer.SumDigProd(0));
            Assert.Equal(9, Reducer.SumDigProd(9));
            Assert.Equal(7, Reducer.SumDigProd(9, 8));
            Assert.Equal(6, Reducer.SumDigProd(16, 28));
            Assert.Equal(1, Reducer.SumDigProd(111111111));
            Assert.Equal(2, Reducer.SumDigProd(1, 2, 3, 4, 5, 6));
            Assert.Equal(6, Reducer.SumDigProd(8, 16, 89, 3));
            Assert.Equal(6, Reducer.SumDigProd(26, 497, 62, 841));
            Assert.Equal(6, Reducer.SumDigProd(17737, 98723, 2));
            Assert.Equal(8, Reducer.SumDigProd(123, -99));
            Assert.Equal(8, Reducer.SumDigProd(167, 167, 167, 167, 167, 3));
            Assert.Equal(2, Reducer.SumDigProd(98526, 54, 863, 156489, 45, 6156));
        }

    }
}