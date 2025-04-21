using System.Collections.Immutable;

namespace InterviewProblemsCSharp.src
{
    public class KMostFrequentCharacters
    {
        internal static MostFrequentCharacter mostFrequentCharacter;

        public List<char> GetKMostFrequentCharacters(String s, int k)
        {
            Dictionary<char, int> characterFrequencies = new Dictionary<char, int>();

            foreach (char c in s)
            {
                characterFrequencies[c] = characterFrequencies.GetValueOrDefault(c, 0) + 1;
            }

            IOrderedEnumerable<KeyValuePair<char, int>> sortedCharacterFrequencies = characterFrequencies.OrderByDescending(kv => kv.Value);

            return sortedCharacterFrequencies
                .Take(k)
                .Select(kv => kv.Key)
                .ToList();
        }
    }
}
