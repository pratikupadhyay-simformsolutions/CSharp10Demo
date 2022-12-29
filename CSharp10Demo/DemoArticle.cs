namespace CSharp10Demo;

public record DemoArticle(string Author, string Title, string Comment) : Article(Author, Title);
