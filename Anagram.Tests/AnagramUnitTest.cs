using System;
using Xunit;
using Anagram;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Tests
{
    public class AnagramUnitTest
    {
        [Fact]
        public void ReportsTrueWhenGivenTwoAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.True(selector.WordPairIsAnagram("restful", "fluster"));
            Assert.True(selector.WordPairIsAnagram("forty five", "over fifty"));
        }
        [Fact]
        public void ReportsFalseWhenGivenTwoNonAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.False(selector.WordPairIsAnagram("something", "else"));
        }
        [Fact]
        public void SelectsAnagramsOfAWordFromAGivenList()
        {
            AnagramList selector = new AnagramList();
            var selection = selector.SelectAnagrams("master",
                new List<string>{"stream", "something", "maters"});

            Assert.True(selection.SequenceEqual(
                new List<string>{"stream", "maters"}));
        }

        [Fact]
        public void IgnoreWhitespacesWhenGivenTwoAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.True(selector.WordPairIsAnagram("a gentleman", "elegant man"));
            Assert.True(selector.WordPairIsAnagram("nag a ram", "anagram"));
        }

        [Fact]
        public void IgnoreSpecialCharactersWhenGivenTwoAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.True(selector.WordPairIsAnagram("Church of Scientology", "rich-chosen goofy cult"));
        }

        [Fact]
        public void IgnoreCasingWhenGivenTwoAnagrams()
        {
            AnagramSelector selector = new AnagramSelector();
            Assert.True(selector.WordPairIsAnagram("George Bush", "He bugs Gore"));
            Assert.True(selector.WordPairIsAnagram("William Shakespeare", "I am a weakish speller"));
        }
    }
}
