using System;

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class IntGenerator
        {
            private static readonly Random _random = new Random();

            public static int GetRandomNumberInRange(int min, int max)
            {
                return _random.Next(min, max + 1);
            }
        }
    }
}
