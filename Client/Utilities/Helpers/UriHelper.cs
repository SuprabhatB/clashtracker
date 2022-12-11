namespace ClashTracker.Client.Utilities.Helpers
{
    public class UriHelper : IUriHelper
    {
        /// <summary>
        /// Routes to.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="paramArgs">The parameter arguments.</param>
        /// <returns></returns>
        public string NavigateTo(string uri, params object[] paramArgs)
        {
            if (string.IsNullOrWhiteSpace(uri))
                return default;

            return string.Format(uri, paramArgs);
        }
    }
}
