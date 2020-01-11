using HashTables;
using System;
using System.Collections;
using Xunit;
using static HashTables.Program;

namespace HashtableTests
{
    public class UnitTest1
    {
        public class TestAdd
        {
            HashTable hashtable = new HashTable(5);

            [Fact]
            public void CanAddOneKeyValue()
            {
                hashtable.Add("A1", "pen");
                Assert.True(hashtable.Contains("A1"));
            }

            [Fact]
            public void CanAddMultipleKeyValues()
            {
                string[] productID = { "A1", "B4", "D6", "F7", "G2", "H3", "J5" };
                string[] product = { "pen", "eraser", "pencil", "ruler", "marker", "note pad", "post-it" };

                HashTable hashtable = new HashTable(productID.Length);
                for (int i = 0; i < productID.Length; i++)
                {
                    hashtable.Add(productID[i], product[i]);
                    Assert.True(hashtable.Contains(productID[i]));
                }
            }

            [Fact]
            public void CanHandleCollision()
            {
                // Only has 1 bucket so both keys will be saved to the same bucket to test if a collision can be handled.
                Hashtable hashtable2 = new Hashtable(1);

                hashtable2.Add("A1", "pen");
                hashtable2.Add("1A", "pencil");
                Assert.True(hashtable2.Contains("1A"));
                Assert.True(hashtable2.Contains("A1"));
            }
        }

        public class TestContains
        {
            HashTable testTable = new HashTable(5);

            [Fact]
            public void ContainsMultiple()
            {
                testTable.Add("April", "4");
                testTable.Add("July", "7");
                testTable.Add("November", "11");
                Assert.True(testTable.Contains("April"));
                Assert.True(testTable.Contains("July"));
                Assert.True(testTable.Contains("November"));
            }

            [Fact]
            public void ContainsOtherKeys()
            {
                testTable.Add("April", "4");
                testTable.Add("July", "7");
                Assert.True(testTable.Contains("April"));
                Assert.True(testTable.Contains("July"));
                Assert.False(testTable.Contains("Decemver"));
            }

            [Fact]
            public void ContainsNoKeys()
            {
                Assert.False(testTable.Contains("December"));
            }
        }

        public class TestGet
        {
            HashTable testTable = new HashTable(10);

            [Fact]
            public void GetOneValue()
            {
                testTable.Add("Monday", "1");
                Assert.Equal("1", testTable.Get("Monday"));
            }

            [Fact]
            public void GetMultipleValues()
            {
                testTable.Add("12345", "First");
                testTable.Add("54321", "Second");
                Assert.Equal("First", testTable.Get("12345"));
                Assert.Equal("Second", testTable.Get("54321"));
            }
        }

        public class TestHash
        {
            HashTable testTable = new HashTable(5);

            [Fact]
            public void HashKeysToTheSameBuckets()
            {
                Assert.Equal(3, testTable.Hash("TAP"));
                Assert.Equal(3, testTable.Hash("PAT"));
            }

            [Fact]
            public void HashKeysToDifferntBucket()
            {
                Assert.Equal(0, testTable.Hash("South Korea"));
                Assert.Equal(1, testTable.Hash("Chile"));
                Assert.Equal(2, testTable.Hash("Italy"));
                Assert.Equal(3, testTable.Hash("Norway"));
                Assert.Equal(4, testTable.Hash("German"));
            }
        }
    }
}
