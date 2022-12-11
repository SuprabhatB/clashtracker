using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum SpinnerType
    {
        /// <summary>
        /// The border only
        /// </summary>
        [Display(Name = "border")]
        BorderOnly,

        /// <summary>
        /// The grow only
        /// </summary>
        [Display(Name = "grow")]
        GrowOnly
    }
}
