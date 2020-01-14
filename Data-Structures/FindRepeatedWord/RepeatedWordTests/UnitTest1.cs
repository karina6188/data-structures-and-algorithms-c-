using System;
using Xunit;
using static FindRepeatedWord.Program;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindFirstRepeated()
        {
            string testString = "I have a corgi named Nuggle and a frenchie names Porkee.";
            Assert.Equal("a",RepeatedWord(testString));
        }

        [Fact]
        public void CanFindFirstRepeatedNoneCaseSensitive()
        {
            string testString = "Wild animals need to stay in the wild.";
            Assert.Equal("wild", RepeatedWord(testString));
        }

        [Fact]
        public void CanFindFirstRepeatedNumber()
        {
            string testString = "Next Thursday is 12/12, which is my best friend's birthday.";
            Assert.Equal("12", RepeatedWord(testString));
        }

        [Fact]
        public void CanTellNoRepeatedWord()
        {
            string testString = "There is no repeated word in this text.";
            Assert.Equal("No repeated word is found", RepeatedWord(testString));
        }
    }
}
