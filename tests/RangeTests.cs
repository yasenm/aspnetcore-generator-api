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
    }
}
