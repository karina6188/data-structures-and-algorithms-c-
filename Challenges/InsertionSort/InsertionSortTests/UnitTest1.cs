using System;
using Xunit;
using static Insertion_Sort.Program;


namespace InsertionSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortUniqueArray()
        {
            int[] array = new int[] { 41, 29, 15, 7, 13, 24, 33, 36 };
            InsertionSort(array);
            int[] test = new int[] { 7, 13, 15, 24, 29, 33, 36, 41 };

            Assert.Equal(test, array);
        }

        [Fact]
        public void CanSortSameValues()
        {
            int[] array = new int[] { 15, 11, 18, 6, 11, 3, 13, 3, 5 };
            InsertionSort(array);
            int[] test = new int[] { 3, 3, 5, 6, 11, 11, 13, 15, 18 };

            Assert.Equal(test, array);
        }

        [Fact]
        public void CanSortUniqueArray()
        {
            int[] array = new int[] { 41, 29, 15, 7, 13, 24, 33, 36 };
            InsertionSort(array);
            int[] test = new int[] { 7, 13, 15, 24, 29, 33, 36, 41 };

            Assert.Equal(test, array);
        }
    }
}
