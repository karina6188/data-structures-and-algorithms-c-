using System;
using Xunit;
using static ArrayShift.Program;

namespace ArrayShiftTests
{
    public class UnitTest1
    {
        [Fact]
        public void ArrayLengthOdd()
        {
            int[] testArray = new int[] { 85, 98, 71, 66, 53 };
            int testValue = 100;
            int[] result = { 85, 98, 71, 100, 66, 53 };
            Assert.Equal(result, insertShiftArray(testArray, testValue));
        }

        [Fact]
        public void ArrayLengthEven()
        {
            int[] testArray = new int[] { 85, 71, 66, 53 };
            int testValue = -100;
            int[] result = { 85, 71, -100, 66, 53 };
            Assert.Equal(result, insertShiftArray(testArray, testValue));
        }

        [Fact]
        public void ArrayHasNoValue()
        {
            int[] testArray = new int[] { };
            int testValue = 100;
            int[] result = { 100 };
            Assert.Equal(result, insertShiftArray(testArray, testValue));
        }
    }
}
