using System;
using Better.RandomDataGenerator.Tests.DataServices;
using Xunit;

namespace Better.RandomDataGenerator.Tests
{
    public class EnumGeneratorTestsShould
    {
        [Fact]
        public void ReturnRandomValueOfEnum()
        {
            var values = RandomValuesService.GenerateRandomValues(RandomDataGenerator.EnumGenerator.GetRandomEnumValue<TestEnum>, 100000);
            
            foreach (TestEnum @enum in Enum.GetValues(typeof(TestEnum)))
            {
                Assert.Contains(@enum, values);
            }

        }

        private enum TestEnum
        {
            Test1,
            Test2,
            Test3,
            Test4
        }
    }
}
