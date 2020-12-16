using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class StringGenerator
        {
            public static string GetRandomTinyString()
            {
                return GetRandomStringByLength(15);
            }

            public static string GetRandomShortString()
            {
                return GetRandomStringByLength(30);
            }

            public static string GetRandomString()
            {
                return GetRandomStringByLength(60);
            }

            public static string GetRandomLargeString()
            {
                return GetRandomStringByLength(200);
            }

            public static string GetRandomStringByLength(int length)
            {
                var chars = new List<char>();
                for (var i = 0; i < length; i++)
                {
                    chars.Add(CharGenerator.GetRandomChar());
                }

                return new string(chars.ToArray());
            }

        }
    }
}
