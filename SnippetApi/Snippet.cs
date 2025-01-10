namespace SnippetApi;

public class Snippet
{
    private static int _nextId = 1;

    internal static readonly List<Snippet> snippets = new List<Snippet>();

    public int Id { get; } = _nextId++;

    public string Language { get; }

    public string Code { get; }

    public Snippet(string language, string code)
    {
        Language = language;
        Code = code;
        snippets.Add(this);
    }
}