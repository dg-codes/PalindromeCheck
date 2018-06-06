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
        [InlineData("civic", 5, "civic")]
        [InlineData("minimum", 5, "minim")]
        [InlineData("bamboo", 10, "oo")]
        [InlineData("mimic", 3, "mim")]
        [InlineData("mimic", 5, "imi")]
        public void GeneratePalindrome_GivenStringContainingPalindrome_ReturnsCorrectText(string input, int pivot, string expected)
        {
            // arrage
            Palindrome actual;

            // act
            actual = (Palindrome)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Equal(expected, actual.Text);
        }

        [Theory]
        [InlineData("civic", 5, 0)]
        [InlineData("minimum", 5, 0)]
        [InlineData("bamboo", 10, 4)]
        [InlineData("mimic", 3, 0)]
        [InlineData("mimic", 5, 1)]
        public void GeneratePalindrome_GivenStringContainingPalindrome_ReturnsCorrectIndex(string input, int pivot, int expected)
        {
            // arrage
            Palindrome actual;

            // act
            actual = (Palindrome)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Equal(expected, actual.StartingIndex);
        }

        [Theory]
        [InlineData("civic", 5, 5)]
        [InlineData("minimum", 5, 5)]
        [InlineData("bamboo", 10, 2)]
        [InlineData("mimic", 3, 3)]
        [InlineData("mimic", 5, 3)]
        public void GeneratePalindrome_GivenStringContainingPalindrome_ReturnsCorrectLength(string input, int pivot, int expected)
        {
            // arrage
            Palindrome actual;

            // act
            actual = (Palindrome)processor.GeneratePalindrome(input, pivot);

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
            Palindrome actual;

            // act
            actual = (Palindrome)processor.GeneratePalindrome(input, pivot);

            // assert
            Assert.Null(actual);
        }

        [Theory]
        [InlineData("civic", 1)]
        [InlineData("minimum", 2)]
        [InlineData("visualstudio", 0)]
        public void GetPalindromes_GivenStringsContainingPalindroms_ContainsTheExpectedNumberOfElements(string input, int expectedCount)
        {
            // arrange
            IList<ISubstring> result;

            // act
            result = processor.GetPalindromes(input);

            // assert
            Assert.Equal(expectedCount, result.Count);
        }

        [Fact]
        public void GetPalindromes_GiveNullInput_ReturnsNull()
        {
            // arrange
            IList<ISubstring> result;

            // act
            result = processor.GetPalindromes(null);

            // assert
            Assert.Null(result);
        }
    }
}
