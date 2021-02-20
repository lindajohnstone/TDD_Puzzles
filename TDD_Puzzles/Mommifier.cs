using System;

namespace TDD_Puzzles
{
    public class Mommifier
    {
        public static string WriteString(string word)
        {
            return word.Replace("i", "mommy").Replace("ea", "mommy");
        }
    }
}