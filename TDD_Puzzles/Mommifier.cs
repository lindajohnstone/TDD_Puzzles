using System;

namespace TDD_Puzzles.Tests
{
    public class Mommifier
    {
        public static string WriteString(string word)
        {
            double vowelCount = GetVowelCount(word);
            return ReplaceVowels(word, vowelCount);
        }

        private static string ReplaceVowels(string word, double vowelCount)
        {
            string[] vowels = { "o", "a", "e", "i", "u" };
            if (vowelCount / word.Length < 0.3) return word;
            word = ReplaceVowels(word, vowels);
            return word;
        }

        private static string ReplaceVowels(string word, string[] vowels)
        {
            foreach (var vowel in vowels)
            {
                word = word.Replace(vowel, "mommy");
            }
            return word;
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