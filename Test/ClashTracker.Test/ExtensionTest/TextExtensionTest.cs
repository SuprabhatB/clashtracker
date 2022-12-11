using ClashTracker.Shared.Extensions;
using ClashTracker.Test.Utilities.Enums;
using NUnit.Framework;

namespace ClashTracker.Test.ExtensionTest
{
    [TestFixture]
    public class TextExtensionTest
    {
        #region Test cases for ToTitleCase
        [Test]
        public void TestConvertToTitleCase()
        {
            var word = "loreum ipsum";
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual("Loreum Ipsum", titleCaseWord);
        }

        [Test]
        public void TestConvertToTitleCaseFromEmptyString()
        {
            var word = string.Empty;
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        [Test]
        public void TestConvertToTitleCaseFromDefaultString()
        {
            var word = default(string);
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        [Test]
        public void TestConvertToTitleCaseFromWhitespaceString()
        {
            var word = " ";
            var titleCaseWord = word.ToTitleCase();

            Assert.AreEqual(null, titleCaseWord);
        }
        #endregion

        #region Test cases for ToCamelCase
        [Test]
        public void TestConvertToCamelCase()
        {
            var word = "LoreumIpsum";
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual("loreumIpsum", titleCaseWord);
        }

        [Test]
        public void TestConvertToCamelCaseFromEmptyString()
        {
            var word = string.Empty;
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        [Test]
        public void TestConvertToCamelCaseFromDefaultString()
        {
            var word = default(string);
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual(null, titleCaseWord);
        }

        [Test]
        public void TestConvertToCamelCaseFromWhitespaceString()
        {
            var word = " ";
            var titleCaseWord = word.ToCamelCase();

            Assert.AreEqual(null, titleCaseWord);
        }
        #endregion

        #region Test cases for Enum DisplayName
        [Test]
        public void TestEnumValueWithoutDisplayName()
        {
            var enumValue = SizeType.Medium.GetDisplayName();

            Assert.AreEqual(nameof(SizeType.Medium), enumValue);
        }

        [Test]
        public void TestEnumValueWithSameDisplayNameAsEnum()
        {
            var enumValue = SizeType.Small.GetDisplayName();

            Assert.AreEqual(nameof(SizeType.Small).ToLowerInvariant(), enumValue);
        }

        [Test]
        public void TestEnumValueWithDifferentDisplayName()
        {
            var enumValue = SizeType.Large.GetDisplayName();

            Assert.AreEqual("lg", enumValue);
        }
        #endregion

        #region Test cases for Removing Whitespace
        [Test]
        public void TestRemoveWhitespacesFromText()
        {
            var twoWordText = "Loreum   Ipsum";
            var twoWordTextResult = twoWordText.RemoveWhiteSpaces();

            Assert.AreEqual("Loreum Ipsum", twoWordTextResult);

            var threeWordText = "Lorem    Ipsum     Dolor";
            var threeWordTextResult = threeWordText.RemoveWhiteSpaces();

            Assert.AreEqual("Lorem Ipsum Dolor", threeWordTextResult);

            var fourWordText = "Lorem    Ipsum     Dolor     Sit ";
            var fourWordTextResult = fourWordText.RemoveWhiteSpaces();

            Assert.AreEqual("Lorem Ipsum Dolor Sit", fourWordTextResult);
        }

        [Test]
        public void TestRemoveWhitespacesFromDefaultText()
        {
            var text = default(string);
            var textResult = text.RemoveWhiteSpaces();

            Assert.AreEqual(null, textResult);
        }

        [Test]
        public void TestRemoveWhitespacesFromEmptyText()
        {
            var text = string.Empty;
            var textResult = text.RemoveWhiteSpaces();

            Assert.AreEqual(null, textResult);
        }
        #endregion

        #region Test case for converting from pascal case to sentence
        [Test]
        public void TestConvertPascalCaseStringToSentenceFromDefaultText()
        {
            var text = default(string);
            var textResult = text.ToSentenceCase();

            Assert.AreEqual(null, textResult);
        }

        [Test]
        public void TestConvertPascalCaseStringToSentenceFromEmptyText()
        {
            var text = string.Empty;
            var textResult = text.ToSentenceCase();

            Assert.AreEqual(null, textResult);
        }

        [Test]
        public void TestConvertPascalCaseStringToSentence()
        {
            var text = "AwaitingFeedback";
            var textResult = text.ToSentenceCase();

            Assert.AreEqual("Awaiting Feedback", textResult);
        }

        #endregion
    }
}
