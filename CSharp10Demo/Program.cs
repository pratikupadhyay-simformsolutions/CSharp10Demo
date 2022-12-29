// Custom interpolated string handlers example
var attribute = "not created"; 

var processedMessage = ProcessMessage($"C# Demo is {attribute}.");

string ProcessMessage(CustomInterpolatedStringHandler builder) => builder.GetFormattedText();

// Lambda expression improvements
var lambda = [DebuggerStepThrough]() => "Hello world";

// Constant interpolated strings example
const string constantAttribute = "created";
const string constantMessage = $"C# Demo is {constantAttribute}.";

// Sealing records ToString method example
var cSharpeDemoArticleRepresentation = new DemoArticle("Author", "Title", "Comment").ToString();

// Assignment and declaration in the same deconstruction example
var articles = (new Article("Author", "Title"), new DemoArticle("Author", "Title", "Comment"));
var article = new Article("Another author", "Another title");

(article, DemoArticle cSharpeDemoArticle) = articles;

var areAuthorsEqual = article.Author == cSharpeDemoArticle.Author;
