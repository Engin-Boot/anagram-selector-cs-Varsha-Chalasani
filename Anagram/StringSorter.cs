using System;
using System.Collections.Generic;

namespace Anagram
{
    public class StringSorter
    {
        public static string SortString(string input)
        {
            char[] characters = input.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}