using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum TextAlignType
    {
        None,

        /// <summary>
        /// The start
        /// </summary>
        [Display(Name = "start")]
        Start,

        /// <summary>
        /// The center
        /// </summary>
        [Display(Name = "center")]
        Center,

        /// <summary>
        /// The end
        /// </summary>
        [Display(Name = "end")]
        End,

        /// <summary>
        /// The justify
        /// </summary>
        [Display(Name = "justify")]
        Justify
    }
}
