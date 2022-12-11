using ClashTracker.Shared.Models.Icon;
using System.Text.Json.Serialization;

namespace ClashTracker.Shared.Models.Label
{
    public class LabeReadModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("iconUrls")]
        public IconUrlReadModel IconUrl { get; set; }
    }
}
