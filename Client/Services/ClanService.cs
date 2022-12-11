using AutoMapper;
using ClashTracker.Client.Extensions;
using ClashTracker.Client.Models.ClientResponse;
using ClashTracker.Client.Services.Interfaces;
using ClashTracker.Shared.Constants;
using ClashTracker.Shared.Extensions;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Clan;
using EnsureThat;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;

namespace ClashTracker.Client.Services
{
    /// <summary>Initializes a new instance of the &lt;see cref="ClanService"/&gt; class.<br /></summary>
    public class ClanService : IClanService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ClanService> _logger;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClanService"/> class.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="logger"></param>
        /// <param name="mapper"></param>
        public ClanService(HttpClient httpClient, ILogger<ClanService> logger, IMapper mapper)
        {
            EnsureArg.IsNotNull(httpClient, nameof(httpClient));
            EnsureArg.IsNotNull(logger, nameof(logger));
            EnsureArg.IsNotNull(mapper, nameof(mapper));

            _httpClient = httpClient;
            _logger = logger;
            _mapper = mapper;
        }


        /// <summary>Gets the clan by name asynchronous.</summary>
        /// <param name="clanName">Name of the clan.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<ClientResponseResultModel<ClanReadModel>> GetClanByNameAsync(ClanSearchModel clanSearch)
        {
            var response = new ClientResponseResultModel<ClanReadModel>();

            try
            {
                using var httpRequest = await _httpClient.PostAsJsonAsync($"{RequestURIConstants.Clan}/{RequestURIConstants.ClanSearch}", clanSearch);
                {
                    var httpResponse = await httpRequest.Content.ReadFromJsonAsync<ApiResponseResultModel<ApiResponseClanModel>>();
                    if (httpResponse != null)
                    {
                        if (httpResponse.StatusCode == HttpStatusCode.OK)
                        {
                            if (httpResponse.Result != null && httpResponse.Result.Items != null && httpResponse.Result.Items.Any())
                            {
                                var data = httpResponse.Result.Items;
                                var mappedData = _mapper.Map<ICollection<ApiResponseClanModel.ClanReadModel>, ICollection<ClanReadModel>>(data);

                                response.Results = mappedData;
                            }
                        }

                        response.Message = httpResponse.Message;
                        response.HasError = httpResponse.HasError;
                    }
                }
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.Message = ex.Message;

                _logger.LogError("Exception occurred at {0}; Message = {1}", this.GetType(), ex.Message);
            }

            return await Task.FromResult(response);
        }

        /// <summary>
        /// Gets the clan by tag asynchronous.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public async Task<ClientResponseResultModel<ClanReadModel>> GetClanByTagAsync(string name)
        {
            var response = new ClientResponseResultModel<ClanReadModel>();

            try
            {
                var httpResponse = await _httpClient.GetFromJsonAsync<ApiResponseResultModel<ApiResponseClanDetailModel>>($"{RequestURIConstants.Clan}/{RequestURIConstants.ClanSearchByTag}/{name}");
                if (httpResponse != null)
                {
                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        //if (httpResponse.Result != null && httpResponse.Result.Items != null && httpResponse.Result.Items.Any())
                        //{
                        //    var data = httpResponse.Result.Items;
                        //    var mappedData = _mapper.Map<ICollection<ApiResponseClanModel.ClanReadModel>, ICollection<ClanReadModel>>(data);

                        //    response.Results = mappedData;
                        //}
                    }

                    response.Message = httpResponse.Message;
                    response.HasError = httpResponse.HasError;
                }
            }
            catch (Exception ex)
            {
                response.HasError = true;
                response.Message = ex.Message;

                _logger.LogError("Exception occurred at {0}; Message = {1}", this.GetType(), ex.Message);
            }

            return await Task.FromResult(response);
        }
    }
}
