namespace ClashTracker.Shared.Models.Clan
{
    public class ClanSearchModel
    {
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
        public string LabelIds { get; set; }
    }
}
