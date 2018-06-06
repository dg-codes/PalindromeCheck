using PalindromeCheck.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck.Models
{
    public class Palindrome : ISubstring, IComparable<Palindrome> 
    {
        public string Text { get; set; }
        public int StartingIndex { get; set; }
        public int Length => Text.Length;

        public int CompareTo(Palindrome other)
        {
            return other.Length - this.Length;
        }

        public override string ToString()
        {
            return $"Text: {this.Text}, Index: {this.StartingIndex}, Length: {this.Length}";
        }
    }
}
