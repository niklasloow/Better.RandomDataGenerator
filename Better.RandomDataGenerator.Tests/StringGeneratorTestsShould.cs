using Better.RandomDataGenerator.Tests.DataServices;
using Xunit;

// ReSharper disable MemberCanBePrivate.Global

namespace Better.RandomDataGenerator.Tests
{
    public class StringGeneratorTestsShould
    {

        [Fact]
        public void ReturnRandomTinyString()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.StringGenerator.GetRandomTinyString, 100);
            Assert.All(values, item => Assert.Single(values, item));
        }

        [Fact]
        public void ReturnRandomShortString()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.StringGenerator.GetRandomShortString, 100);
            Assert.All(values, item => Assert.Single(values, item));
        }

        [Fact]
        public void ReturnRandomString()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.StringGenerator.GetRandomString, 100);
            Assert.All(values, item => Assert.Single(values, item));
        }

        [Fact]
        public void ReturnRandomLargeString()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.StringGenerator.GetRandomLargeString, 100);
            Assert.All(values, item => Assert.Single(values, item));
        }

        [Fact]
        public void ReturnRandomStringByLength()
        {
            const int length = 10;
            
            var values = RandomValuesService.GenerateRandomValues(() => RandomDataGenerator.StringGenerator.GetRandomStringByLength(length), 100);
            
            Assert.All(values, item => Assert.Single(values, item));
        }

        [Fact]
        public void ReturnRandomStringByLengthCorrectLength()
        {
            const int length = 10;

            var randomString = RandomDataGenerator.StringGenerator.GetRandomStringByLength(length);
            
            Assert.Equal(length, randomString.Length);


        }

        [Fact]
        public void CharsInNotBeTheSames()
        {
            const int length = 10000;

            var randomString = RandomDataGenerator.StringGenerator.GetRandomStringByLength(length).ToCharArray();
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach (var @char in chars)
            {
                Assert.Contains(@char, randomString);
            }


        }

    }
}
