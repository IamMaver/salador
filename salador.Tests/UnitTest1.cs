using salador.Core;

namespace salador.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void TestSlaladorRepeatNoRepeat()
        {

            //Arrange

            int[] input = { 1, 2, 3 };
            int[] expected = { };
            int[] actual;

            //Act

            actual = ClassRepeats.FindRepeat(input).ToArray();

            //Assert

            Assert.Equal(expected, actual); ;
        }

        [Fact]
        public void TestSlaladorRepeatIsRepeat()
        {

            //Arrange

            int[] input = { 1, 2, 3, 1, 8, 3 };
            int[] expected = { 1, 3 };
            int[] actual;

            //Act

            actual = ClassRepeats.FindRepeat(input).ToArray();

            //Assert

            Assert.Equal(expected, actual); ;
        }
    }
}