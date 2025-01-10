using Microsoft.AspNetCore.Mvc;

namespace SnippetApi.Controllers;

[ApiController]
[Route("snippets")]

public class SnippetController(ILogger<SnippetController> logger) : ControllerBase
{
    private readonly ILogger<SnippetController> _logger = logger;

    [HttpPost]
    public ObjectResult CreateSnippet([FromBody] Snippet snippet)
    {
        return StatusCode(201, snippet);
    }

    [HttpGet]
    public List<Snippet> GetSnippets()
    {
        return Snippet.snippets;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Snippet> GetSnippetById(int id)
    {
        var snippet = Snippet.snippets.FirstOrDefault(s => s.Id == id);

        if (snippet == null)
        {
            return NotFound();
        }

        return Ok(snippet);
    }
}