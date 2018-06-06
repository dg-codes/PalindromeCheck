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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
