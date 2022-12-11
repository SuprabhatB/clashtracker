using ClashTracker.Shared.Models.Clan;
using System.Collections.Generic;

namespace ClashTracker.Client.Pages.Views.Clan
{
    public partial class ClanList
    {
        ICollection<ClanReadModel> Clans { get; set; }
    }
}
