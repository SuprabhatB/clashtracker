using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Utilities.Enums
{
    public enum TableScopeType
    {
        None,

        /// <summary>
        /// The col
        /// </summary>
        [Display(Name = "col")]
        Col,

        /// <summary>
        /// The row
        /// </summary>
        [Display(Name = "row")]
        Row,

        /// <summary>
        /// The col group
        /// </summary>
        [Display(Name = "colgroup")]
        ColGroup,

        /// <summary>
        /// The row group
        /// </summary>
        [Display(Name = "rowgroup")]
        RowGroup
    }
}
