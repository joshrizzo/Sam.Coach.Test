using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        LongestRisingSequenceFinder target = new LongestRisingSequenceFinder();

        [Theory]
        [InlineData(new[] { 4, 3, 5, 5 }, new[] { 3, 5 })]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 0, -3 }, new[] { 3, 5, 8 })]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 0, 0, 0, -3 }, new[] { 3, 5, 8 })]
        [InlineData(new[] { 4, 3, 5, 8, 5, 6, 7, 0, 0, -3 }, new[] { 3, 5, 8 })]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 1, 4, 12 }, new[] { 0, 1, 4, 12 })]
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            var actual = await target.Find(data);

            actual.Should().Equal(expected);
        }
    }
}
