using System;
using System.Collections.Generic;

namespace Anagram
{
    public class Preprocessor
    {
        public static string stringPreprocess(string phrase)
        {
            phrase = normaliseCasing(phrase);
            phrase = removeOtherCharacters(phrase);

            return phrase;
        }

        static string removeOtherCharacters(string phrase)
        {
            char[] characters = phrase.ToCharArray();
            char[] phraseArray = Array.FindAll(characters, x => x >= 97 && x <= 122);
            return new string(phraseArray);
        }

        static string normaliseCasing(string phrase)
        {
            phrase = phrase.ToLower();
            return phrase;
        }
    }
}