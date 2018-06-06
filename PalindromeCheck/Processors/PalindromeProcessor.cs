using PalindromeCheck.Interfaces;
using PalindromeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck.Processors
{
    public class PalindromeProcessor : IPalindromeProcessor
    {
        public IList<ISubstring> GetPalindromes(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            int pivotingLenght = 2 * input.Length + 1;
            var palindromes = new List<ISubstring>();

            for (int i = 0; i < pivotingLenght; i++)
            {
                var palindrome = (Substring)GeneratePalindrome(input, i);

                if (palindrome == null || string.IsNullOrWhiteSpace(palindrome.Text)) continue;

                if (palindrome.Length > 1) // not considering letter as being palindromes
                {
                    palindromes.Add(palindrome);
                }

            }

            return palindromes;
        }

        public ISubstring GeneratePalindrome(string input, int pivot)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            int left = pivot / 2;
            int right = left + pivot % 2;

            while (left > 0 && right < input.Length && input[left - 1] == input[right])
            {
                left--;
                right++;
            }

            var result = new Substring
            {
                Text = input.Substring(left, right - left),
                Index = left,
            };

            return result;
        }
    }
}
