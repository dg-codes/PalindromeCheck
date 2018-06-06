using PalindromeCheck.Interfaces;
using PalindromeCheck.Models;
using PalindromeCheck.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();

            IPalindromeProcessor processor = new PalindromeProcessor();
            List<Palindrome> palindromes = processor.GetPalindromes(input).OfType<Palindrome>().ToList();

            palindromes.Sort();
            foreach (var item in palindromes.Take(3))
            {
                Console.WriteLine(item);
            }
        }
    }
}
