using AutoMapper;
using ClashTracker.Client.Models.Clan;
using ClashTracker.Client.Services.Interfaces;
using ClashTracker.Client.Utilities.Enums;
using ClashTracker.Shared.Models.Clan;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClashTracker.Client.Pages.Views.Clan
{
    public partial class ClanSearchForm
    {
        [Inject] IClanService ClanService { get; set; }
        [Inject] IMapper Mapper { get; set; }

        [Parameter] public EventCallback<ICollection<ClanReadModel>> OnClanSearch { get; set; }

        ClanSearchFormModel SearchForm { get; set; } = new ClanSearchFormModel();

        bool IsSearchByName => SearchForm.SearchType == ClanSearchType.Name;
        bool IsSearchByTag => SearchForm.SearchType == ClanSearchType.Tag;

        bool IsSearching { get; set; }

        /// <summary>
        /// Searches the clan asynchronous.
        /// </summary>
        async Task SearchClanAsync()
        {
            IsSearching = true;

            var mappedData = Mapper.Map<ClanSearchFormModel, ClanSearchModel>(SearchForm);
            var response = await ClanService.GetClanByNameAsync(mappedData);
            if (response != null)
            {
                if (response.HasError)
                {
                    Console.WriteLine($"Error: {response.Message}");
                }

                await OnClanSearch.InvokeAsync(response.Results);
            }

            IsSearching = false;
        }

        /// <summary>
        /// Clears the search title.
        /// </summary>
        async Task ClearSearchAsync()
        {
            SearchForm.Name = default;

            await OnClanSearch.InvokeAsync(default);
        }
    }
}
