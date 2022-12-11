using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum ColorType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The primary
        /// </summary>
        [Display(Name = "primary")]
        Primary,

        /// <summary>
        /// The secondary
        /// </summary>
        [Display(Name = "secondary")]
        Secondary,

        /// <summary>
        /// The success
        /// </summary>
        [Display(Name = "success")]
        Success,

        /// <summary>
        /// The danger
        /// </summary>
        [Display(Name = "danger")]
        Danger,

        /// <summary>
        /// The warning
        /// </summary>
        [Display(Name = "warning")]
        Warning,

        /// <summary>
        /// The information
        /// </summary>
        [Display(Name = "info")]
        Info,

        /// <summary>
        /// The light
        /// </summary>
        [Display(Name = "light")]
        Light,

        /// <summary>
        /// The dark
        /// </summary>
        [Display(Name = "dark")]
        Dark,
    }
}
