using System.Text.Json;

namespace Better.RandomDataGenerator
{
    public static partial class RandomDataGenerator
    {
        public static class CharGenerator
        {
            public static char GetRandomChar()
            {
                var num = RandomDataGenerator.IntGenerator.GetRandomNumberInRange(0, 26);
                return (char)('A' + num);
            }
        }
    }

    
}
