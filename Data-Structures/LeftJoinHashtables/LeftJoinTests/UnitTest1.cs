using LeftJoinHashtables;
using System;
using Xunit;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodesIntoHashTable()
        {
            HashTable test = new HashTable(5);
            test.AddNode("A", "American Crow");
            test.AddNode("B", "Blue Jay");
            test.AddNode("C", "Columbidae");
            test.AddNode("D", "Dark-eyed Junco");
            test.AddNode("E", "European Starling");

            Assert.Equal(0, test.Contains("A"));
            Assert.Equal(1, test.Contains("B"));
            Assert.Equal(2, test.Contains("C"));
            Assert.Equal(3, test.Contains("D"));
            Assert.Equal(4, test.Contains("E"));
        }

        [Fact]
        public void CanCheckIfHashTableHasAKey()
        {
            HashTable test = new HashTable(5);
            test.AddNode("A", "American Crow");
            test.AddNode("B", "Blue Jay");
            test.AddNode("C", "Columbidae");
            test.AddNode("D", "Dark-eyed Junco");
            test.AddNode("E", "European Starling");

            Assert.Equal(0, test.Contains("A"));
            Assert.Equal(1, test.Contains("B"));
            Assert.Equal(2, test.Contains("C"));
            Assert.Equal(-1, test.Contains("G"));
            Assert.Equal(-1, test.Contains("H"));
        }

        [Fact]
        public void CanGetNodesValue()
        {
            HashTable test = new HashTable(5);
            test.AddNode("A", "American Crow");
            test.AddNode("B", "Blue Jay");
            test.AddNode("C", "Columbidae");
            test.AddNode("D", "Dark-eyed Junco");
            test.AddNode("E", "European Starling");

            Assert.Equal("American Crow", test.HashNode[0].Value);
            Assert.Equal("Blue Jay", test.HashNode[1].Value);
            Assert.Equal("Columbidae", test.HashNode[2].Value);
            Assert.Equal("Dark-eyed Junco", test.HashNode[3].Value);
            Assert.Equal("European Starling", test.HashNode[4].Value);
        }

        [Fact]
        public void CanJoinTwoTables()
        {
            HashTable test = new HashTable(5);
            test.AddNode("A", "American Crow");
            test.AddNode("B", "Blue Jay");
            test.AddNode("C", "Columbidae");
            test.AddNode("D", "Dark-eyed Junco");
            test.AddNode("E", "European Starling");

            HashTable test2 = new HashTable(3);
            test2.AddNode("A", "American Robin");
            test2.AddNode("C", "Chipping Sparrow");
            test2.AddNode("M", "Mallard");

            HashTable result = Program.LeftJoin(test, test2);

            HashTable expected = new HashTable(5);
            expected.AddNode("A", "American Crow, American Robin");
            expected.AddNode("B", "Blue Jay, null");
            expected.AddNode("C", "Columbidae, Chipping Sparrow");
            expected.AddNode("D", "Dark-eyed Junco, null");
            expected.AddNode("E", "European Starling, null");

            Assert.Equal(expected.HashNode[0].Value, result.HashNode[0].Value);
            Assert.Equal(expected.HashNode[1].Value, result.HashNode[1].Value);
            Assert.Equal(expected.HashNode[2].Value, result.HashNode[2].Value);
            Assert.Equal(expected.HashNode[3].Value, result.HashNode[3].Value);
            Assert.Equal(expected.HashNode[4].Value, result.HashNode[4].Value);
        }

        [Fact]
        public void CanCheckIfAHashTableHasEmptyRow()
        {
            HashTable test = new HashTable(5);
            test.AddNode("A", "American Crow");
            test.AddNode("B", "Blue Jay");
            test.AddNode("C", "Columbidae");

            Assert.False(Program.PrintTable(test));
        }
    }
}
