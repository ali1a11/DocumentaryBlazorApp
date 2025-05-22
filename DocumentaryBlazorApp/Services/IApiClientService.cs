using DocumentaryBlazorApp.Models;

namespace DocumentaryBlazorApp.Services
{
    public interface IApiClientService
    {
        // Documentaries
        Task<List<Documentary>?> GetAllDocumentariesAsync();
        Task<Documentary?> GetDocumentaryByIdAsync(int id);
        Task<List<Documentary>?> GetDocumentariesByCategoryAsync(string category);

        // Categories
        Task<List<string>> GetCategoriesAsync();

        // Reviews
        Task<List<Review>?> GetAllReviewsAsync();
        Task<List<Review>?> GetReviewsForDocumentaryAsync(int documentaryId);
        Task AddReview(Review review);
    }
}