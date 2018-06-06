using PalindromeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck.Interfaces
{
    public interface IPalindromeProcessor
    {
        IList<ISubstring> GetPalindromes(string input);
        ISubstring GeneratePalindrome(string input, int pivot);
    }
}
