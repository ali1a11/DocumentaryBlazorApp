using Swashbuckle.AspNetCore.Filters;
using DocumentaryBlazorApp.Models;

namespace DocumentaryBlazorApp.Models
{
    public class ReviewExample : IExamplesProvider<Review>
    {
        public Review GetExamples()
        {
            return new Review
            {
                DocumentaryId = 5,
                Rating = 4,
                DatePosted = DateTime.UtcNow
            };
        }
    }
}