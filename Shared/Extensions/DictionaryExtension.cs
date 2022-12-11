using System.Collections.Generic;

namespace ClashTracker.Shared.Extensions
{
    public static class DictionaryExtension
    {
        public static void SafeAdd<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.ContainsKey(key)) return;

            dict.Add(key, value);
        }

        public static void SafeUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (!dict.ContainsKey(key)) return;

            dict[key] = value;
        }

        public static void SafeDelete<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            if (!dict.ContainsKey(key)) return;

            dict.Remove(key);
        }

        public static TValue SafeGet<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            dict.TryGetValue(key, out var value);

            return value;
        }
    }
}
