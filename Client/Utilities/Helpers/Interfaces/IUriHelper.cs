namespace ClashTracker.Client.Utilities.Helpers
{
    public interface IUriHelper
    {
        /// <summary>
        /// Routes to.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="paramArgs">The parameter arguments.</param>
        /// <returns></returns>
        string NavigateTo(string uri, params object[] paramArgs);
    }
}
