using System.Collections.Immutable;

namespace InterviewProblemsCSharp.src
{
    public class MostFrequentCharacter
    {
        internal static MostFrequentCharacter mostFrequentCharacter;

        public char GetMostFrequentCharacter(String s)
        {
            Dictionary<char, int> characterFrequencies = new Dictionary<char, int>();

            foreach (char c in s)
            {
                characterFrequencies[c] = characterFrequencies.GetValueOrDefault(c, 0) + 1;
            }

            IOrderedEnumerable<KeyValuePair<char, int>> sortedCharacterFrequencies = characterFrequencies.OrderByDescending(kv => kv.Value);
            return sortedCharacterFrequencies.First().Key;
        } 
    }
}
