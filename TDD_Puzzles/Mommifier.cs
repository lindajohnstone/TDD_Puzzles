using System;

namespace TDD_Puzzles.Tests
{
    public class Mommifier
    {
        public static string WriteString(string word)
        {
            int vowelCount = GetVowelCount(word);
            if ((vowelCount / word.Length) > 0.3) return word;
            return word.Replace("i", "mommy").Replace("ea", "mommy");
        }

        private static int GetVowelCount(string word)
        {
            var vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vowel in vowels)
            {
                if (word.Contains(vowel)) vowelCount++;
            }

            return vowelCount;
        }
    }
}