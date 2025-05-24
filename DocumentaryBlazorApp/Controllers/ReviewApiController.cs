using Microsoft.AspNetCore.Mvc;
using DocumentaryBlazorApp.Models;
using DocumentaryBlazorApp.Services;
using Swashbuckle.AspNetCore.Filters;

namespace DocumentaryBlazorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewApiController : ControllerBase
    {
        private readonly IDocumentaryService _service;

        public ReviewApiController(IDocumentaryService service)
        {
            _service = service;
        }

        // Retrieves all reviews.
        // GET: api/ReviewApi
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reviews = await _service.GetAllReviewsAsync();
            return Ok(reviews);
        }

        // Retrieves all reviews for a specific documentary.
        // GET: api/ReviewApi/Documentary/5
        [HttpGet("Documentary/{documentaryId}")]
        public async Task<IActionResult> GetReviewsForDocumentary(int documentaryId)
        {
            var reviews = await _service.GetReviewsForDocumentaryAsync(documentaryId);
            return Ok(reviews);
        }

        // Adds a new review for a documentary.
        // POST: api/ReviewApi
        [HttpPost]
       [SwaggerRequestExample(typeof(Review), typeof(ReviewExample))]
        public async Task<IActionResult> AddReview([FromBody] Review review)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.AddReviewAsync(review);
            return CreatedAtAction(nameof(GetReviewsForDocumentary), new { documentaryId = review.DocumentaryId }, review);
        }
    }
}

