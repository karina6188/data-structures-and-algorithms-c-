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
            int[] array1 = new int[] { 41, 29, 15, 7, 13, 24, 33, 36 };
            InsertionSort(array1);

        }
    }
}
