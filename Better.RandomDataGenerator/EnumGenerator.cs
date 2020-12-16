using System;

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class EnumGenerator
        {
            public static T GetRandomEnumValue<T>() where T : Enum
            {
                var values = Enum.GetValues(typeof(T));
                //TODO - Replace with correct random from int
                var random = new Random();
                var randomValue = (T) values.GetValue(random.Next(values.Length));
                return randomValue;
            }
        }
    }
}
