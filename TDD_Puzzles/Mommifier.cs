using System;

namespace TDD_Puzzles
{
    public class Mommifier
    {
        public static object WriteString(string word)
        {
            return word.Replace("i", "mommy");
        }
    }
}