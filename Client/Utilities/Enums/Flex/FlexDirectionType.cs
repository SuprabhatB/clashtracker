using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum FlexDirectionType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The default
        /// </summary>
        Default,

        /// <summary>
        /// The reverse
        /// </summary>
        [Display(Name = "reverse")]
        Reverse
    }
}
