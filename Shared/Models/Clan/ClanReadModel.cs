using ClashTracker.Shared.Models.Badge;
using ClashTracker.Shared.Models.Location;
using System.Text.Json.Serialization;

namespace ClashTracker.Shared.Models.Clan
{
    public class ClanReadModel
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public LocationReadModel Location { get; set; }

        [JsonPropertyName("badgeUrls")]
        public BadgeUrlReadModel Badge { get; set; }
        public int ClanLevel { get; set; }
        public int ClanPoints { get; set; }
        public int ClanVersusPoints { get; set; }
        public int RequiredTrophies { get; set; }
        public string WarFrequency { get; set; }
        public int WarWinStreak { get; set; }
        public int WarWins { get; set; }
        public int WarTies { get; set; }
        public int WarLosses { get; set; }
        public bool IsWarLogPublic { get; set; }
        public int Members { get; set; }
        public int RequiredVersusTrophies { get; set; }
        public int RequiredTownhallLevel { get; set; }
    }
}
