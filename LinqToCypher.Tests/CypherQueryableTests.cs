using System.Linq;
using Xunit;

namespace LinqToCypher.Tests
{
    public class CypherQueryableTests
    {
        // I don't want to write tests of Remotion, but I do want to verify that I'm using Remotion correctly.
        [Fact]
        public void ShouldBeAbleToExecute()
        {
            var sut = new CypherQueryable<int>();
            sut.ToList();
        }

        [Fact]
        public void ShouldBeAbleToWriteBasicQueries()
        {
            var sut = new CypherQueryable<int>();
            sut.Where(i => i == 123);
        }
    }
}
