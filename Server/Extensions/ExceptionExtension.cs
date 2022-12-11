using ClashTracker.Server.Handlers.Exceptions;
using ClashTracker.Shared.Models.ApiResponse;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;

namespace ClashTracker.Server.Extensions
{
    public static class ExceptionExtension
    {
        /// <summary>
        /// Gets the empty response exception result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="ere">The ere.</param>
        /// <param name="response">The response.</param>
        /// <param name="logger">The logger.</param>
        public static void GetEmptyResponseExceptionResult<T, U>(
            this EmptyResponseExceptionHandler<T> ere,
            ApiResponseResultModel<T> response,
            ILogger<U> logger)
        {
            response.HasError = true;
            response.Message = ere.Message;
            logger.LogError($"{0} exception; Message = {1}", ere.GetType(), ere.Message);
        }

        /// <summary>
        /// Gets the HTTP request exception result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="hte">The hte.</param>
        /// <param name="response">The response.</param>
        /// <param name="logger">The logger.</param>
        public static void GetHttpRequestExceptionResult<T, U>(
            this HttpRequestException hte,
            ApiResponseResultModel<T> response,
            ILogger<U> logger)
        {
            response.HasError = true;
            response.Message = hte.Message;
            logger.LogError($"{0} exception; Message = {1}", hte.GetType(), hte.Message);
        }


        /// <summary>
        /// Gets the empty response exception result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="ex">The ex.</param>
        /// <param name="response">The response.</param>
        /// <param name="logger">The logger.</param>
        public static void GetEmptyResponseExceptionResult<T, U>(
            this Exception ex,
            ApiResponseResultModel<T> response,
            ILogger<U> logger)
        {
            response.HasError = true;
            response.Message = ex.Message;
            logger.LogError($"{0} exception; Message = {1}; Stack Trace = {2}", ex.GetType(), ex.Message, ex.StackTrace);
        }
    }
}
