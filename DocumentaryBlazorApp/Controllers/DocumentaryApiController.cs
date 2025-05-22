using Microsoft.AspNetCore.Mvc;
using DocumentaryBlazorApp.Services;
using DocumentaryBlazorApp.Models;

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

        // GET: api/DocumentaryApi
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
                var docs = await _service.GetAllDocumentariesAsync();
                return Ok(docs);
        }

        // GET: api/DocumentaryApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var doc = await _service.GetDocumentaryByIdAsync(id);
            if (doc == null)
                return NotFound();
            return Ok(doc);
        }

        // GET: api/DocumentaryApi/5/reviews
        [HttpGet("{id}/reviews")]
        public async Task<IActionResult> GetReviews(int id)
        {
            var reviews = await _service.GetReviewsForDocumentaryAsync(id);
            return Ok(reviews);
        }

        // Returns a distinct list of all available categories.
        // GET: api/DocumentaryApi/categories
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _service.GetCategoriesAsync();
            return Ok(categories);
        }

        // Returns all documentaries matching the specified category.
        // GET: api/DocumentaryApi/category/{category}
        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetByCategory(string category)
        {
            var docs = await _service.GetDocumentariesByCategoryAsync(category);
            return Ok(docs);
        }
    }
}