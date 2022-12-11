using System.Collections.Generic;

namespace ClashTracker.Client.Models.ClientResponse
{
    public class ClientResponseResultModel<T> where T : class
    {
        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        public ICollection<T> Results { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has error; otherwise, <c>false</c>.
        /// </value>
        public bool HasError { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public object Message { get; set; }
    }
}
