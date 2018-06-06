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
            throw new NotImplementedException();
        }

        public ISubstring GeneratePalindrome(string input, int pivot)
        {
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
