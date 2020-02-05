using System;
using Xunit;
using static Insertion_Sort.Program;


namespace InsertionSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void SortUniqueArray()
        {
            int[] array = new int[] { 41, 29, 15, 7, 13, 24, 33, 36 };
            InsertionSort(array);
            int[] test = new int[] { 7, 13, 15, 24, 29, 33, 36, 41 };

            Assert.Equal(test, array);
        }

        [Fact]
        public void SortSameValues()
        {
            int[] array = new int[] { 15, 11, 18, 6, 11, 3, 13, 3, 5 };
            InsertionSort(array);
            int[] test = new int[] { 3, 3, 5, 6, 11, 11, 13, 15, 18 };

            Assert.Equal(test, array);
        }

        [Fact]
        public void SortReservedArray()
        {
            int[] array = new int[] { 65, 60, 55, 50, 45, 40, 35, 30 };
            InsertionSort(array);
            int[] test = new int[] { 30, 35, 40, 45, 50, 55, 60, 65 };

            Assert.Equal(test, array);
        }

        [Fact]
        public void SortNearlySorted()
        {
            int[] array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, -10, 0 };
            InsertionSort(array);
            int[] test = new int[] { -10, 0, 2, 4, 6, 8, 10, 12, 14, 16 };

            Assert.Equal(test, array);
        }
    }
}
