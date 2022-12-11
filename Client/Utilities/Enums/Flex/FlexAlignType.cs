using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum FlexAlignType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The start
        /// </summary>
        [Display(Name = "start")]
        Start,

        /// <summary>
        /// The end
        /// </summary>
        [Display(Name = "end")]
        End,

        /// <summary>
        /// The center
        /// </summary>
        [Display(Name = "center")]
        Center,

        /// <summary>
        /// The baseline
        /// </summary>
        [Display(Name = "baseline")]
        Baseline,

        /// <summary>
        /// The stretch
        /// </summary>
        [Display(Name = "stretch")]
        Stretch,
    }
}
