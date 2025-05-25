using Microsoft.AspNetCore.Mvc;
using DocumentaryBlazorApp.Services;

namespace DocumentaryBlazorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentaryApiController : ControllerBase
    {
        private readonly IDocumentaryService _service;

        public DocumentaryApiController(IDocumentaryService service)
        {
            _service = service;
        }

        // Retrieves a list of all documentaries.
        // GET: api/DocumentaryApi
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
                var docs = await _service.GetAllDocumentariesAsync();
                return Ok(docs);
        }

        // Retrieves a specific documentary by its ID.
        // GET: api/DocumentaryApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var doc = await _service.GetDocumentaryByIdAsync(id);
            if (doc == null)
                return NotFound();
            return Ok(doc);
        }


        // Retrieves a distinct list of all available categories.
        // GET: api/DocumentaryApi/categories
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _service.GetCategoriesAsync();
            return Ok(categories);
        }

        // Retrieves all documentaries matching the specified category.
        // GET: api/DocumentaryApi/category/{category}
        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetByCategory(string category)
        {
            var docs = await _service.GetDocumentariesByCategoryAsync(category);
            return Ok(docs);
        }
    }
}