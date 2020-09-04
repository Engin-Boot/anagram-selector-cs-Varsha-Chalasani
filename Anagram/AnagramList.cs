using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramList
    {
        public List<string> SelectAnagrams(string word, List<string> candidates)
        {
            //Insert the correct implementation here
            List<string> anagramList = new List<string> { };
            foreach (string str in candidates)
            {
                CheckAndAddAnagramsToList(word, str, anagramList);
            }
            return anagramList;
        }
        public List<string> CheckAndAddAnagramsToList(string word, string str, List<string> anagramList)
        {
            AnagramSelector selector = new AnagramSelector();
            if (selector.WordPairIsAnagram(word, str))
            {
                anagramList.Add(str);
            }
            return anagramList;
        }
    }
}