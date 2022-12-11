using AutoMapper;
using ClashTracker.Client.Services.Interfaces;
using ClashTracker.Shared.Extensions;
using ClashTracker.Shared.Models.Clan;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace ClashTracker.Client.Pages.Views.Clan
{
    public partial class ClanDetail
    {
        [Inject] IClanService ClanService { get; set; }

        [Parameter] public string Tag { get; set; }

        ClanReadModel Clan { get; set; }

        bool IsSearching { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Clan ??= new ClanReadModel();

            if (Tag.HasValue())
            {
                await GetClanDetailsAsync();
            }
        }

        async Task GetClanDetailsAsync()
        {
            IsSearching = true;

            var response = await ClanService.GetClanByTagAsync(Tag);
            if (response != null)
            {
                if (response.HasError)
                {
                    Console.WriteLine($"Error: {response.Message}");
                }
            }

            IsSearching = false;
        }
    }
}
