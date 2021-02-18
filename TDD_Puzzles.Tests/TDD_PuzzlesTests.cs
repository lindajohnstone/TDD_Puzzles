using System;
using Xunit;

namespace TDD_Puzzles.Tests
{
    public class TDD_PuzzlesTests
    {
        [Fact]
        public void Return_Original_String()
        {
            // arrange
            var expected = "hard";
            // act
            var result = Mommifier.WriteString("hard");
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Replace_Vowel_In_Word_With_Mommy()
        {
            // arrange
            var expected = "hmommys";
            // act
            var result = Mommifier.WriteString("his");
            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Replace_More_Than_One_Vowel_With_Mommy()
        {
            // arrange
            var expected = "hmommyr";
            // act
            var result = Mommifier.WriteString("hear");
            // assert
            Assert.Equal(expected, result);
        }
    }
}
