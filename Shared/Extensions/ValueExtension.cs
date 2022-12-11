using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ClashTracker.Shared.Extensions
{
    public static class TextExtension
    {
        /// <summary>
        /// Converts to titlecase.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ToTitleCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Converts to camelcase.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ToCamelCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

        /// <summary>
        /// Serializes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string Serialize(this object value, bool isCaseInsensitivePropertyName = false)
        {
            if (value == null)
                return default;

            return JsonSerializer.Serialize(value, new JsonSerializerOptions { PropertyNameCaseInsensitive = isCaseInsensitivePropertyName });
        }

        /// <summary>
        /// Deserializes the specified allow checking case insensitive.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="isCaseInsensitivePropertyName">if set to <c>true</c> [allow checking case insensitive].</param>
        /// <returns></returns>
        public static T Deserialize<T>(this string value, bool isCaseInsensitivePropertyName = false) where T : class
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return JsonSerializer.Deserialize<T>(value, new JsonSerializerOptions { PropertyNameCaseInsensitive = isCaseInsensitivePropertyName });
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum value)
        {
            var displayAttribute = value.GetType()
                                        .GetMember(value.ToString())
                                        .First()
                                        .GetCustomAttribute<DisplayAttribute>();

            return displayAttribute?.GetName() ?? value.ToString();
        }

        /// <summary>
        /// Removes the white spaces.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string RemoveWhiteSpaces(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return Regex.Replace(value, @"\s+", " ").Trim();
        }

        /// <summary>
        /// Converts to sentencecase.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ToSentenceCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return Regex.Replace(value, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToUpper(m.Value[1]));
        }

        /// <summary>
        /// Determines whether the specified value has value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value has value; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
