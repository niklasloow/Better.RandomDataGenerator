using System;
using System.Collections.Generic;
using System.Text;

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class TimeSpanGenerator
        {
            public static TimeSpan GetRandomTimeSpan()
            {
                return TimeSpan.FromMilliseconds(IntGenerator.GetRandomNumberInRange(1, 200000000));
            }
        }
    }
}
