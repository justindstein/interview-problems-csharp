using InterviewProblemsCSharp.src;
using Xunit;

namespace InterviewProblemsCSharp.test
{
    public class MostFrequentCharacterTest
    {
        /*
         * Most Frequent Character in a String
         * ---------------------------------------
         * Given a string `s`, find and return the character that appears most frequently in the string.
         * If there are multiple characters with the same maximum frequency, return the one that appears first in the string.
         * The input string can contain letters (both uppercase and lowercase), digits, and special characters.
         *
         * Examples:
         *
         * Example 1:
         * Input:    s = "abbbccde"
         * Output:   'b'
         * Explanation: 'b' appears 3 times, which is more than any other character.
         *
         * Example 2:
         * Input:    s = "aabbcc"
         * Output:   'a'
         * Explanation: 'a', 'b', and 'c' all appear 2 times, but 'a' appears first.
         *
         * Example 3:
         * Input:    s = "!@#!!@@"
         * Output:   '!'
         * Explanation: '!' and '@' both appear 3 times, but '!' comes first.
         */

        [Fact]
        public void example1()
        {
            String s = "abbbccde";

            char expected = 'b';
            char actual = new MostFrequentCharacter().GetMostFrequentCharacter(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void example2()
        {
            String s = "aabbcc";

            char expected = 'a';
            char actual = new MostFrequentCharacter().GetMostFrequentCharacter(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void example3()
        {
            String s = "!@#!!@@";

            char expected = '!';
            char actual = new MostFrequentCharacter().GetMostFrequentCharacter(s);

            Assert.Equal(expected, actual);
        }
    }
}
