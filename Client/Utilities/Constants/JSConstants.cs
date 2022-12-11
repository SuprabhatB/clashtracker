using ClashTracker.Shared.Extensions;
using System.Runtime.CompilerServices;

namespace ClashTracker.Client.Utilities.Constants
{
    public class JSConstants
    {
        static string GetValue([CallerMemberName] string name = null)
        {
            return $"JSInteropService.{name.ToCamelCase()}";
        }

        public static string Logger => GetValue();
        public static string IconInit => GetValue();
        public static string ToggleSidebar => GetValue();
        public static string SetTableEmptyRowWidth => GetValue();
    }
}
