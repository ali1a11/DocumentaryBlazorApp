using Microsoft.EntityFrameworkCore;
using DocumentaryBlazorApp.Data;
using DocumentaryBlazorApp.Models;
using Serilog;

namespace DocumentaryBlazorApp.Services
{
    public class DocumentaryService : IDocumentaryService
    {
        private readonly ApplicationDbContext documentaryDBContext;

        public DocumentaryService(ApplicationDbContext documentaryDBContext)
        {
            this.documentaryDBContext = documentaryDBContext;
        }

        // Documentaries
        public async Task<List<Documentary>?> GetAllDocumentariesAsync()
        {
            return await documentaryDBContext.Documentaries
                .Include(d => d.Reviews)
                .ToListAsync();
        }

        public async Task<Documentary?> GetDocumentaryByIdAsync(int id)
        {
            return await documentaryDBContext.Documentaries
                .Include(d => d.Reviews)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Documentary>> GetDocumentariesByCategoryAsync(string category)
        {
            return await documentaryDBContext.Documentaries
                .Where(d => d.Category == category)
                .ToListAsync();
        }

        // Categories
        public async Task<List<string>> GetCategoriesAsync()
        {
            var categories = await documentaryDBContext.Documentaries
                .Select(d => d.Category)
                .Distinct()
                .ToListAsync();

            return categories;
        }

        // Reviews
        public async Task<List<Review>> GetAllReviewsAsync()
        {
            return await documentaryDBContext.Reviews
                .ToListAsync();
        }

        public async Task<List<Review>> GetReviewsForDocumentaryAsync(int documentaryId)
        {
            return await documentaryDBContext.Reviews
                .Where(r => r.DocumentaryId == documentaryId)
                .OrderByDescending(r => r.DatePosted)
                .ToListAsync();
        }

        public async Task AddReviewAsync(Review review)
        {
            documentaryDBContext.Reviews.Add(review);
            try
            {
                await documentaryDBContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                Log.Error(ex, "Error occurred while saving the review to the database.");
                throw; // the global exception middleware handle the response
            }
        }
    }
}
