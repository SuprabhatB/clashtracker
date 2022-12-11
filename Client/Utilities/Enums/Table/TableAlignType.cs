using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum TableAlignType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The top
        /// </summary>
        [Display(Name = "top")]
        Top,

        /// <summary>
        /// The middle
        /// </summary>
        [Display(Name = "middle")]
        Middle,

        /// <summary>
        /// The bottom
        /// </summary>
        [Display(Name = "bottom")]
        Bottom
    }
}
