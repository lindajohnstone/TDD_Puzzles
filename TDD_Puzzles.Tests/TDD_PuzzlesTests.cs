using System;
using Xunit;

namespace TDD_Puzzles.Tests
{
    public class TDD_PuzzlesTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var expected = "hard";
            var actual = new Mommifier();
            // act
            var result = actual.WriteString("hard");
            // assert
            Assert.Equal(expected, result);
        }
    }
}
