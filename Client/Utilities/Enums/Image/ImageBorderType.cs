using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum ImageBorderType
    {
        None,

        /// <summary>
        /// The rounded
        /// </summary>
        [Display(Name = "rounded")]
        Rounded,

        /// <summary>
        /// The rounded circle
        /// </summary>
        [Display(Name = "circle")]
        Circle
    }
}
