using System.Linq;
using System.Web;

namespace ClashTracker.Client.Extensions
{
    public static class QueryExtension
    {
        private const string quertStringSeperator = "&";

        /// <summary>
        /// Gets the query string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static string GetQueryString<T>(this T source) where T : class
        {
            var type = source.GetType();
            var propertyInfo = type.GetProperties();
            var properties = propertyInfo
                .Where(pi =>
                {
                    var propType = pi.PropertyType;
                    var value = pi.GetValue(source, default);

                    if (propType.Equals(typeof(string)))
                    {
                        return value != null;
                    }
                    else if (propType.Equals(typeof(int)))
                    {
                        return (int)value != 0;
                    }

                    return default;
                })
                .Select(pi => $"{pi.Name}={HttpUtility.UrlEncode(pi.GetValue(source, default).ToString())}");

            return string.Join(quertStringSeperator, properties.ToArray());
        }
    }
}
