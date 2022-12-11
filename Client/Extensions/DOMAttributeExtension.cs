using ClashTracker.Client.Utilities.Constants;
using ClashTracker.Client.Utilities.Enums;
using ClashTracker.Shared.Extensions;

namespace ClashTracker.Client.Extensions
{
    public static class DOMAttributeExtension
    {
        /// <summary>
        /// Gets the size of the border.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string GetBorderSize(this BorderSizeType value)
        {
            if (value.Equals(BorderSizeType.None)) return default;

            return $"{UIConstants.RoundedPrefix}-{(int)value}";
        }

        /// <summary>
        /// Gets the table variant.
        /// </summary>
        /// <param name="colorType">Type of the color.</param>
        /// <returns></returns>
        public static string GetTableVariant(this ColorType colorType)
        {
            if (colorType == ColorType.None)
                return default;

            return $"{UIConstants.TablePrefix}-{colorType.GetDisplayName()}";
        }

        /// <summary>
        /// Gets the table align.
        /// </summary>
        /// <param name="alignType">Type of the align.</param>
        /// <returns></returns>
        public static string GetTableAlign(this TableAlignType alignType)
        {
            if (alignType == TableAlignType.None)
                return default;

            return $"{UIConstants.AlignPrefix}-{alignType.GetDisplayName()}";
        }

        public static string GetTextAlign(this TextAlignType alignType)
        {
            if (alignType == TextAlignType.None)
                return default;

            return $"{UIConstants.TextPrefix}-{alignType.GetDisplayName()}";
        }
    }
}
