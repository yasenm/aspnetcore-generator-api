using System;
using System.Linq;
using api.Controllers;
using Xunit;

namespace tests
{
    public class RangeTests
    {
        [Fact]
        public void CountShouldControlNumberOfResults()
        {
            var range = new Range { Count = 3 };

            var generate = range.Of(() => "");

            Assert.Equal(3, generate.Count());
        }

        [Fact]
        public void SortShouldOrderResult()
        {
            var range = new Range { Count = 3, Sort = true };
            var values = new[] {"a","c", "b"};
            var counter = 0;
            var generate = range.Of(() => values[counter++]);

            Assert.Equal(new[] {"a","b", "c"}, generate.ToArray());
        }
    }
}
