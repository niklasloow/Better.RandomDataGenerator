using Better.RandomDataGenerator.Tests.DataServices;
using Xunit;

namespace Better.RandomDataGenerator.Tests
{
    public class IntGeneratorTestsShould
    {
        [Fact]
        public void ReturnRandomValueOfInt()
        {
            var values = RandomValuesService.GenerateRandomValues(() => RandomDataGenerator.IntGenerator.GetRandomNumberInRange(0, 10), 10000);

            for (var i = 0; i < 10; i++)
            {
                Assert.Contains(i, values);
            }
        }

        [Fact]
        public void InRangeOfParameters()
        {
            var values = RandomValuesService.GenerateRandomValues(() => RandomDataGenerator.IntGenerator.GetRandomNumberInRange(1, 10), 10000);

            foreach (var randomInt in values)
            {
                Assert.InRange(randomInt, 1, 10);
            }
        }
    }
}
