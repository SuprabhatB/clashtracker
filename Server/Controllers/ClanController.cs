using ClashTracker.Client.Extensions;
using ClashTracker.Server.Extensions;
using ClashTracker.Server.Handlers.Exceptions;
using ClashTracker.Shared.Constants;
using ClashTracker.Shared.Extensions;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Clan;
using ClashTracker.Shared.Models.Configuration;
using EnsureThat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace ClashTracker.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ClanController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettingOptions _appSettingOptions;
        private readonly ILogger<ClanController> _logger;

        public ClanController(HttpClient httpClient, IOptions<AppSettingOptions> options, ILogger<ClanController> logger)
        {
            EnsureArg.IsNotNull(httpClient, nameof(httpClient));
            EnsureArg.IsNotNull(options, nameof(options));

            _appSettingOptions = options.Value;

            httpClient.BaseAddress ??= new Uri(_appSettingOptions.RequestEndPointURI);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _appSettingOptions.AuthKey);

            _httpClient = httpClient;
            _logger = logger;
        }

        [HttpPost]
        [ActionName(RequestURIConstants.ClanSearch)]
        public async Task<ApiResponseResultModel<ApiResponseClanModel>> GetAsync([Required, FromBody] ClanSearchModel clanSearch)
        {
            var query = clanSearch != null ? clanSearch.GetQueryString() : default;

            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"clans?{query}");
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = new ApiResponseResultModel<ApiResponseClanModel>();

            try
            {
                var httpResponse = await _httpClient.SendAsync(requestMessage);

                if (httpResponse == null)
                    throw new EmptyResponseExceptionHandler<ApiResponseClanModel>(response);

                if (httpResponse != null)
                {
                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        var responseBody = await httpResponse.Content.ReadAsStringAsync();
                        if (!string.IsNullOrWhiteSpace(responseBody))
                        {
                            response.Result = responseBody.Deserialize<ApiResponseClanModel>(true);
                        }
                    }
                    else
                    {
                        response.HasError = true;
                        response.Message = httpResponse.StatusCode.ToString();
                    }

                    response.StatusCode = httpResponse.StatusCode;
                }
            }
            catch (EmptyResponseExceptionHandler<ApiResponseClanModel> ereh)
            {
                ereh.GetEmptyResponseExceptionResult(response, _logger);
            }
            catch (HttpRequestException hte)
            {
                hte.GetEmptyResponseExceptionResult(response, _logger);
            }
            catch (Exception ex)
            {
                ex.GetEmptyResponseExceptionResult(response, _logger);
            }

            return response;
        }

        [HttpGet]
        [ActionName(RequestURIConstants.ClanSearchByTag)]
        public async Task<ApiResponseResultModel<ApiResponseClanDetailModel>> GetByTagAsync([Required, FromQuery] string name)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"clans/{HttpUtility.UrlEncode(name)}");
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = new ApiResponseResultModel<ApiResponseClanDetailModel>();

            try
            {
                var httpResponse = await _httpClient.SendAsync(requestMessage);

                if (httpResponse == null)
                    throw new EmptyResponseExceptionHandler<ApiResponseClanDetailModel>(response);

                if (httpResponse != null)
                {
                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        var responseBody = await httpResponse.Content.ReadAsStringAsync();
                        if (!string.IsNullOrWhiteSpace(responseBody))
                        {
                            response.Result = responseBody.Deserialize<ApiResponseClanDetailModel>(true);
                        }
                    }
                    else
                    {
                        response.HasError = true;
                        response.Message = httpResponse.StatusCode.ToString();
                    }

                    response.StatusCode = httpResponse.StatusCode;
                }
            }
            catch (EmptyResponseExceptionHandler<ApiResponseClanDetailModel> ereh)
            {
                ereh.GetEmptyResponseExceptionResult(response, _logger);
            }
            catch (HttpRequestException hte)
            {
                hte.GetEmptyResponseExceptionResult(response, _logger);
            }
            catch (Exception ex)
            {
                ex.GetEmptyResponseExceptionResult(response, _logger);
            }

            return response;
        }
    }
}
