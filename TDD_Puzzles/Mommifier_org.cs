using System;

namespace TDD_Puzzles.Tests
{
    public class Mommifier_org
    {
        public static string WriteString(string word)
        {
            return ReplaceVowels(word, GetVowelCount(word));
        }

        private static string ReplaceVowels(string word, double vowelCount)
        {
            string[] vowels = { "o", "a", "e", "i", "u" };
            if (vowelCount / word.Length < 0.3) return word;
            char[] letters = word.ToCharArray();
            // loop through array
            // check if letter is a vowel
            // remember index
            // if index+1 is a vowel
            // replace the first vowel only
            foreach (var letter in letters)
            {
                
            }
            return ReplaceVowels(word, vowels);
        }

        private static string ReplaceVowels(string word, string[] vowels)
        {
            foreach (var vowel in vowels)
            {
                word = word.Replace(vowel, "mommy");
            }
            return word;
        }

        private static double GetVowelCount(string word)
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