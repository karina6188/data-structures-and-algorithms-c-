using System;
using Xunit;
using static QuickSort.Program;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray()
        {
            int[] testArray = { 5, 7, 4, 9, 1, 3, 8, 2, 6 };
            Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(resultArray, Quicksort(testArray, 0, testArray.Length - 1));
        }

        [Fact]
        public void CanSortSameValues()
        {
            int[] testArray = { 7, 7, 7, 5, 7, 1, 7 };
            Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 1, 5, 7, 7, 7, 7, 7 };
            Assert.Equal(resultArray, Quicksort(testArray, 0, testArray.Length - 1));
        }

        [Fact]
        public void CanSortReverse()
        {
            int[] testArray = { 11, 9, 7, 5, 3, 1 };
            Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 1, 3, 5, 7, 9, 11 };
            Assert.Equal(resultArray, Quicksort(testArray, 0, testArray.Length - 1));
        }

        [Fact]
        public void CanSortAllZeros()
        {
            int[] testArray = { 0, 0, 0, 0, 0, 0, 0 };
            Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 0, 0, 0, 0, 0, 0, 0 };
            Assert.Equal(resultArray, Quicksort(testArray, 0, testArray.Length - 1));
        }

        [Fact]
        public void CanPrintArray()
        {
            int[] testArray = { 8, 4, 23, 42, 16, 15 };
            PrintArray(testArray);
            string output = "[8, 4, 23, 42, 16, 15]";
            Assert.Equal(output, PrintArray(testArray));
        }
    }
}
