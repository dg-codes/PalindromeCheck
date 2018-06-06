using PalindromeCheck.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck.Models
{
    public class Substring : ISubstring, IComparable<Substring> 
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public int Length => Text.Length;

        public int CompareTo(Substring other)
        {
            return other.Length - this.Length;
        }

        public override string ToString()
        {
            return $"Text: {this.Text}, Index: {this.Index}, Length: {this.Length}";
        }
    }
}
