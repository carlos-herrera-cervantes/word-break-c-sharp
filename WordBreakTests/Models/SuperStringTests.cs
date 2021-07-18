using WordBreakDomain.Models;
using Xunit;

namespace WordBreakTests.Models
{
    public class SuperStringTests
    {
        [Fact]
        public void IsWordBreak_Should_Return_True()
        {
            var dict = new [] { "apple", "pen" };
            var str = "applepenapple";

            var result = SuperString.IsWordBreak(str, dict);

            Assert.True(result);
        }
    }
}