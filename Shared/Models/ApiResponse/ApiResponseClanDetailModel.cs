using System.Collections.Generic;

namespace ClashTracker.Shared.Models.ApiResponse
{
    public class ApiResponseClanDetailModel
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public LocationReadModel Location { get; set; }
        public BadgeUrlReadModel BadgeUrls { get; set; }
        public int ClanLevel { get; set; }
        public int ClanPoints { get; set; }
        public int ClanVersusPoints { get; set; }
        public int RequiredTrophies { get; set; }
        public string WarFrequency { get; set; }
        public int WarWinStreak { get; set; }
        public int WarWins { get; set; }
        public int WarTies { get; set; }
        public int warLosses { get; set; }
        public bool IsWarLogPublic { get; set; }
        public WarLeagueReadModel WarLeague { get; set; }
        public int Members { get; set; }
        public ICollection<LabelReadModel> Labels { get; set; }
        public ChatLanguageReadModel ChatLanguage { get; set; }
        public int RequiredVersusTrophies { get; set; }
        public int RequiredTownhallLevel { get; set; }

        public class LocationReadModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsCountry { get; set; }
            public string CountryCode { get; set; }
        }

        public class BadgeUrlReadModel
        {
            public string Small { get; set; }
            public string Large { get; set; }
            public string Medium { get; set; }
        }

        public class WarLeagueReadModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class LabelReadModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IconUrlReadModel IconUrls { get; set; }
        }

        public class ChatLanguageReadModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LanguageCode { get; set; }
        }

        public class IconUrlReadModel
        {
            public string Small { get; set; }
            public string Medium { get; set; }
        }
    }
}
