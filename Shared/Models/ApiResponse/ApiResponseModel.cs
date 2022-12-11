using ClashTracker.Shared.Models.Direction;
using System.Collections.Generic;

namespace ClashTracker.Shared.Models.ApiResponse
{
    public class ApiResponseModel<T>
    {
        public ICollection<T> Items { get; set; }
        public Paging Paging { get; set; }
    }
}
