using System;
using Xunit;
using static BinarySearch.Program;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnFound()
        {
            int[] array = new int[] { 22, 35, 38, 57, 65 };
            int key = 57;
            Assert.Equal(3, Binary_Search(array, key));
        }

        [Fact]
        public void ReturnNotFound()
        {
            int[] array = new int[] { 22, 35, 38, 57, 65 };
            int key = 100;
            Assert.Equal(-1, Binary_Search(array, key));
        }

        [Fact]
        public void NegativeArray()
        {
            int[] array = new int[] { -21, -16, -8, -3, 0 };
            int key = -25;
            Assert.Equal(-1, Binary_Search(array, key));
        }
    }
}
