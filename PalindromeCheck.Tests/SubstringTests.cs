using PalindromeCheck.Interfaces;
using PalindromeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeCheck.Tests
{
    public class SubstringTests
    {
        [Fact]
        public void CompareTo_GivenLongerString_ReturnsPositiveValue()
        {
            // arrange
            var substring = new Substring() { Text = "substring" };
            var other = new Substring() { Text = "comparison test" };

            // act
            int actual = substring.CompareTo(other);

            // assert
            Assert.True(actual > 0);
        }

        [Fact]
        public void CompareTo_GivenLongerString_ReturnsNegativeValue()
        {
            // arrange
            var substring = new Substring() { Text = "substring" };
            var other = new Substring() { Text = "other" };

            // act
            int actual = substring.CompareTo(other);

            // assert
            Assert.True(actual < 0);
        }

        [Fact]
        public void CompareTo_GivenSameLengthString_ReturnsZero()
        {
            // arrange
            var substring = new Substring() { Text = "equal." };
            var other = new Substring() { Text = "length" };

            // act
            int actual = substring.CompareTo(other);

            // assert
            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData("Actual", 1, 6)]
        [InlineData("Palindrom", 2, 9)]
        [InlineData(" ", 1, 1)]
        [InlineData("", 0, 0)]
        public void ToString_GivenValidInput_ConcatenatesTheCorrectString(string text, int index, int length)
        {
            // arrange
            var substring = new Substring
            {
                Text = text,
                Index = index
            };
            string expected = $"Text: {text}, Index: {index}, Length: {length}";

            // act
            string actual = substring.ToString();

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_GivenNullText_ThrowsNullReferenceException()
        {
            // arrange
            var substring = new Substring();

            // act

            // assert
            Assert.Throws<NullReferenceException>(() => { substring.ToString(); });
        }

    }
}
