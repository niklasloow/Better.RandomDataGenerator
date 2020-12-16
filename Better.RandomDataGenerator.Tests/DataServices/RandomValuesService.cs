using System;
using System.Collections.Generic;

namespace Better.RandomDataGenerator.Tests.DataServices
{
    public static class RandomValuesService
    {
        public static IEnumerable<T> GenerateRandomValues<T>(Func<T> func, int numberOfGenerations)
        {
            var values = new List<T>();

            for (var i = 0; i < numberOfGenerations; i++)
            {
                values.Add(func());
            }

            return values;
        }
    }
}