using ClashTracker.Shared.Models.ApiResponse;
using System;
using System.Net;

namespace ClashTracker.Server.Handlers.Exceptions
{
    public class EmptyResponseExceptionHandler<T> : Exception
    {
        public EmptyResponseExceptionHandler() { }

        public EmptyResponseExceptionHandler(ApiResponseResultModel<T> apiResponseResult)
        : base($"Response is empty")
        {
            apiResponseResult.StatusCode = HttpStatusCode.NoContent;
        }
    }
}
