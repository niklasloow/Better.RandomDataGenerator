using System;

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class BoolGenerator
        {
            public static bool GetRandomBool()
            {
                var randomInt = IntGenerator.GetRandomNumberInRange(0, 1);
                return Convert.ToBoolean(randomInt);
            }
        }
    }
}
