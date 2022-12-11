using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    /// <summary>
    /// Button type
    /// </summary>
    public enum ButtonType
    {
        /// <summary>
        /// The button
        /// </summary>
        [Display(Name = "button")]
        Button,

        /// <summary>
        /// The submit
        /// </summary>
        [Display(Name = "submit")]
        Submit,

        /// <summary>
        /// The reset
        /// </summary>
        [Display(Name = "reset")]
        Reset
    }
}