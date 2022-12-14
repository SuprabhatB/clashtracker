using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum ModalSizeType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The sm
        /// </summary>
        [Display(Name = "sm")]
        SM,


        /// <summary>
        /// The lg
        /// </summary>
        [Display(Name = "lg")]
        LG,

        /// <summary>
        /// The xl
        /// </summary>
        [Display(Name = "xl")]
        XL
    }
}
