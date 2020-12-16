using Better.RandomDataGenerator.Tests.DataServices;
using Xunit;

namespace Better.RandomDataGenerator.Tests
{
    public class BoolGeneratorTestsShould
    {

        [Fact]
        public void ReturnRandomBool()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.BoolGenerator.GetRandomBool, 100);

            Assert.Contains(true, values);
            Assert.Contains(false, values);

        }
    }
}
