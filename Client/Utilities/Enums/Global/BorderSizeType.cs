namespace ClashTracker.Client.Utilities.Enums
{
    /// <summary>
    /// Use the scaling classes for larger or smaller rounded corners. Sizes range from 0 to 3.
    /// </summary>
    public enum BorderSizeType
    {
        /// <summary>
        /// Default
        /// </summary>
        None = -1,

        /// <summary>
        /// Rounded 0%
        /// </summary>
        Rounded_0,

        /// <summary>
        /// Rounded 20%
        /// </summary>
        Rounded_1,

        /// <summary>
        /// Rounded 37.5%
        /// </summary>
        Rounded_2,

        /// <summary>
        /// Rounded 50%
        /// </summary>
        Rounded_3
    }
}
