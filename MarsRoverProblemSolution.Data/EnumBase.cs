using System;
using System.Linq;

namespace MarsRoverProblemSolution.Data
{
    public class EnumBase
    {
        private static readonly Type SelfType = typeof(EnumBase);
        public string Key { get; set; }
        public int Value { get; set; }

        public EnumBase(string key, int value)
        {
            this.Key = key;
            this.Value = value;
        }

        public EnumBase(string key)
        {
            this.Key = key;
        }


        public static T FromKey<T>(string key) where T : EnumBase
        {
            var type = typeof(T);
            var properties = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

            return properties
                .Where(c => SelfType.IsAssignableFrom(c.PropertyType))
                .Select(c => c.GetValue(null) as T)
                .FirstOrDefault(c => c.Key == key);
        }
    }
}
