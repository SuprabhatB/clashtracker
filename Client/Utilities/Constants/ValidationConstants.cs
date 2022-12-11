namespace ClashTracker.Client.Utilities.Constants
{
    public class ValidationConstants
    {
        public const string RequiredMessage = "{0} is required";
        public const string AlphabetsAndNumbersOnlyMessage = "{0} contains invalid characters. Only Alphabets and Numbers allowed.";
        public const string MaximumCharacterLengthMessage = "{0} must have min length of {2} and max Length of {1}";

        public const int ClanNameMaxCharacterLength = 15;
        public const int ClanNameMinCharacterLength = 3;
    }
}
