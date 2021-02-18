using System;

namespace TDD_Puzzles.Tests
{
    public class Mommifier
    {
        public static string WriteString(string word)
        {
            word = word.Replace("i", "mommy");
            return word;
        }
    }
}