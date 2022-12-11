using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Test.Utilities.Enums
{
    public enum SizeType
    {
        /// <summary>
        /// The small
        /// </summary>
        [Display(Name = "small")]        
        Small,

        /// <summary>
        /// The medium
        /// </summary>
        Medium,

        /// <summary>
        /// The large
        /// </summary>
        [Display(Name = "lg")]        
        Large
    }
}
