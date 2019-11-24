using System;
using Xunit;
using static MergeSort.Program;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortArray()
        {
            int[] testArray = { 5, 7, 4, 9, 1, 3, 8, 2, 6 };
            Mergesort(testArray);
            int[] resultArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(resultArray, Mergesort(testArray));
        }

        [Fact]
        public void CanSortSameValues()
        {
            int[] testArray = { 7, 7, 7, 5, 7, 1, 7 };
            Mergesort(testArray);
            int[] resultArray = { 1, 5, 7, 7, 7, 7, 7 };
            Assert.Equal(resultArray, Mergesort(testArray));
        }

        [Fact]
        public void CanSortReverse()
        {
            int[] testArray = { 11, 9, 7, 5, 3, 1 };
            Mergesort(testArray);
            int[] resultArray = { 1, 3, 5, 7, 9, 11 };
            Assert.Equal(resultArray, Mergesort(testArray));
        }
    }
}
