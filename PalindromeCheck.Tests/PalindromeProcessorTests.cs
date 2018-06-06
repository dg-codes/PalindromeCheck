using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeCheck.Processors;
using PalindromeCheck.Interfaces;
using Xunit;
using PalindromeCheck.Models;

namespace PalindromeCheck.Tests
{
    public class PalindromeProcessorTests
    {
        IPalindromeProcessor processor;

        public PalindromeProcessorTests()
        {
            processor = new PalindromeProcessor();
        }

        [Theory]
        [InlineData("civic", 0, "civic")]
        [InlineData("minimum", 0, "minim")]
        [InlineData("minimum", 1, "ini")]
        [InlineData("bamboo", 0, "oo")]
        public void GeneratePalindrome_GivenStringContainingPalindrome_ReturnsCorrectText(string input, int pivot, string expected)
        {
            // arrage
            Substring actual;

            // act
            actual = (Substring)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Equal(expected, actual.Text);
        }

        [Theory]
        [InlineData("civic", 0, 0)]
        [InlineData("minimum", 0, 0)]
        [InlineData("minimum", 1, 1)]
        [InlineData("bamboo", 0, 4)]
        public void GeneratePalindrome_GivenStringContainingPalindrome_ReturnsCorrectIndex(string input, int pivot, int expected)
        {
            // arrage
            Substring actual;

            // act
            actual = (Substring)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Equal(expected, actual.Index);
        }

        [Theory]
        [InlineData("civic", 0, 5)]
        [InlineData("minimum", 0, 5)]
        [InlineData("minimum", 1, 3)]
        [InlineData("bamboo", 0, 2)]
        public void GeneratePalindrome_GivenStringContainingPalindrome_ReturnsCorrectLength(string input, int pivot, int expected)
        {
            // arrage
            Substring actual;

            // act
            actual = (Substring)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Equal(expected, actual.Length);
        }

        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        public void GeneratePalindrome_GivenNullOrEmptyInput_ReturnsNull(string input, int pivot)
        {
            // arrage
            Substring actual;

            // act
            actual = (Substring)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Null(actual);
        }
    }
}
