using System;
using System.Collections.Generic;
using static Anagram.Preprocessor;
using static Anagram.StringSorter;
namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2)
        {
            string localCopyWord1 = word1;
            string localCopyWord2 = word2;
            //Insert the correct implementation here
            localCopyWord1 = stringPreprocess(localCopyWord1);
            localCopyWord2 = stringPreprocess(localCopyWord2);
            
            localCopyWord1 = SortString(localCopyWord1);
            localCopyWord2 = SortString(localCopyWord2);

            return (localCopyWord1 == localCopyWord2);
        } 
    }
}
