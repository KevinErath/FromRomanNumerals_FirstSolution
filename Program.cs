using System;
using System.Collections.Generic;
using System.Linq;

namespace FromRomanNumerals
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var mapping = new Dictionary<string, int> {{"I", 1}, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000}, {"IV", 4}, {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400}, {"CM", 900}};
            var number = 0;
            var lastChar = "-";
            foreach (var chr in args[0].Select(x => x.ToString()))
            {
                if (mapping.ContainsKey(lastChar + chr))
                {
                    number += mapping[lastChar + chr] - mapping[lastChar];
                }
                else
                {
                    number += mapping[chr];
                }
                lastChar = chr;
            }
            Console.WriteLine("{0} -> {1}", args[0], number);
        }
    }
}