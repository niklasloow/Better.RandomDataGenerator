using System;
using System.Collections.Generic;
using System.Text;
using Better.RandomDataGenerator.Tests.DataServices;
using Xunit;

namespace Better.RandomDataGenerator.Tests
{
    public class TimeSpanGeneratorTestsShould
    {
        [Fact]
        public void ReturnARandomTimeSpan()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.TimeSpanGenerator.GetRandomTimeSpan, 100);
            Assert.All(values, item => Assert.Single(values, item));
        }
    }
}
