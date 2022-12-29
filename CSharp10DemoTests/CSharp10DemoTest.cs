using CSharp10Demo;
using Xunit;

namespace Tests
{
    public class CSharp10DemoTest
    {
        [Fact]
        public void WhenDemoIsCreatedWithParameterlessConstructor_ThenPropertyIsInitialized()
        {
            // When
            var demo = new Demo();

            // Then
            Assert.Equal(10, demo.Size);
        }

        [Fact]
        public void GivenCustomInterpolatedStringHandler_WhenStringIsFormatted_ThenCustomFormatIsApplied()
        {
            // Given
            var attribute = "not created";
            CustomInterpolatedStringHandler builder = $"C# Demo is {attribute}.";

            // When
            var proccesedString = builder.GetFormattedText();

            // Then
            Assert.Equal("C# Demo is created.", proccesedString);
        }

        [Fact]
        public void GivenArticleAndcSharpeDemoArticleWithSameAuthorAndTitle_WhenTheyAreRepresentedAsString_ThenTheirRepresentationIsEqual()
        {
            // Given
            var article = new Article("Author", "Title");
            var cSharpeDemoArticle = new DemoArticle("Author", "Title", "Comment");

            // When
            var articleStringRepresentation = article.ToString();
            var cSharpeDemoArticleStringRepresentation = cSharpeDemoArticle.ToString();

            // Then
            Assert.Equal(cSharpeDemoArticleStringRepresentation, articleStringRepresentation);
        }
    }
}