using System;

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class DecimalGenerator
        {
            public static decimal GetRandomDecimal()
            {
                var randomInt = IntGenerator.GetRandomNumberInRange(100, 10000000);
                return randomInt / 10.0m;
            }
        }
    }
}
