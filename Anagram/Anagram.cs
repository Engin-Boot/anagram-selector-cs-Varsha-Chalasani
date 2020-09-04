using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2)
        {
            //Insert the correct implementation here
            StringSorter sorter = new StringSorter();
            word1 = sorter.SortString(word1);
            word2 = sorter.SortString(word2);

            return (word1==word2);
        } 
    }
}
