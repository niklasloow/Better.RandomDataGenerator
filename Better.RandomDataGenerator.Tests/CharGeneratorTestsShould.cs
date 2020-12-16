using Better.RandomDataGenerator.Tests.DataServices;
using Xunit;

namespace Better.RandomDataGenerator.Tests
{
    public class CharGeneratorTestsShould
    {
        [Fact]
        public void ReturnRandomChar()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.CharGenerator.GetRandomChar, 100000);

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            foreach (var @char in chars)
            {

                Assert.Contains(@char, values);
            }
        }
    }
}
