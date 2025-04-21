using InterviewProblemsCSharp.src;
using Xunit;

namespace InterviewProblemsCSharp.test
{
    public class KMostFrequentCharactersTest
    {
        /*
         * K Most Frequent Characters in a String
         * -----------------------------------------
         * Given a string `s` and an integer `k`, return a list of the `k` most frequently occurring characters in the string.
         * If there are multiple characters with the same maximum frequency, characters that appear earlier in the string should be prioritized.
         * The result should be a list of characters, ordered from most to least frequent.
         * The input string can contain letters (both uppercase and lowercase), digits, and special characters.
         * 
         * Examples:
         * 
         * Example 1:
         * Input:    s = "aabbbccde", k = 2
         * Output:   ["b", "a"]
         * Explanation: 'b' appears 3 times, 'a' appears 2 times. They are the top 2.
         * 
         * Example 2:
         * Input:    s = "xyzzzzxxyy", k = 3
         * Output:   ["z", "x", "y"]
         * Explanation: 'z' appears 4 times, 'x' 3 times, 'y' 3 times. 'x' appears before 'y'.
         * 
         * Example 3:
         * Input:    s = "abc", k = 5
         * Output:   ["a", "b", "c"]
         * Explanation: The string has only 3 distinct characters.
         */

        [Fact]
        public void example1()
        {
            String s = "aabbbccde";
            int k = 2;

            List<char> expected = new List<char>{ 'b','a'};
            List<char> actual = new KMostFrequentCharacters().GetKMostFrequentCharacters(s, k);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void example2()
        {
            String s = "xyzzzzxxyy";
            int k = 3;

            List<char> expected = new List<char> { 'z', 'x', 'y' };
            List<char> actual = new KMostFrequentCharacters().GetKMostFrequentCharacters(s, k);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void example3()
        {
            String s = "abc";
            int k = 5;

            List<char> expected = new List<char> { 'a', 'b', 'c' };
            List<char> actual = new KMostFrequentCharacters().GetKMostFrequentCharacters(s, k);

            Assert.Equal(expected, actual);
        }
    }
}
