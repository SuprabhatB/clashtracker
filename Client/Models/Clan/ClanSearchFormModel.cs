using ClashTracker.Client.Utilities.Constants;
using ClashTracker.Client.Utilities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClashTracker.Client.Models.Clan
{
    public class ClanSearchFormModel
    {
        [Display(Name = "Clan Name")]
        [Required(ErrorMessage = ValidationConstants.RequiredMessage)]
        [StringLength(ValidationConstants.ClanNameMaxCharacterLength, MinimumLength = ValidationConstants.ClanNameMinCharacterLength, ErrorMessage = ValidationConstants.MaximumCharacterLengthMessage)]
        [RegularExpression(RegexConstants.AlphabetsAndNumbersOnly, ErrorMessage = ValidationConstants.AlphabetsAndNumbersOnlyMessage)]
        public string Name { get; set; }
        public string WarFrequency { get; set; }
        public int LocationId { get; set; }
        public int MinMembers { get; set; }
        public int MaxMembers { get; set; }
        public int MinClanPoints { get; set; }
        public int MinClanLevel { get; set; }
        public int Limit { get; set; }
        public string After { get; set; }
        public string Before { get; set; }
        public bool IsSearchByTag => SearchType == ClanSearchType.Tag;
        public ClanSearchType SearchType { get; set; }
        public IEnumerable<string> Labels { get; set; }

        public string SearchTerm => IsSearchByTag ? $"#{Name}" : Name;
        public bool HasName => !string.IsNullOrWhiteSpace(Name);
    }
}
