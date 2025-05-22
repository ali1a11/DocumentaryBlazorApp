using System.Net.Http.Json;
using DocumentaryBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DocumentaryBlazorApp.Services
{
    public class ApiClientService : IApiClientService
    {
        private readonly HttpClient _http;

        public ApiClientService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Documentary>?> GetAllDocumentariesAsync()
        {
            return await _http.GetFromJsonAsync<List<Documentary>>("api/DocumentaryApi");
        }

        public async Task<Documentary?> GetDocumentaryByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<Documentary>($"api/DocumentaryApi/{id}");
        }

        public async Task<List<Documentary>> GetDocumentariesByCategoryAsync(string category)
        {
            return await _http.GetFromJsonAsync<List<Documentary>>($"api/DocumentaryApi/category/{category}");
        }

        public async Task<List<string>> GetCategoriesAsync()
        {
            return await _http.GetFromJsonAsync<List<string>>("api/DocumentaryApi/categories");
        }

        public async Task<List<Review>> GetAllReviewsAsync()
        {
            return await _http.GetFromJsonAsync<List<Review>>("api/ReviewApi");
        }

        public async Task<List<Review>> GetReviewsForDocumentaryAsync(int documentaryId)
        {
            return await _http.GetFromJsonAsync<List<Review>>($"api/ReviewApi/Documentary/{documentaryId}");
        }

        public async Task AddReview(Review review)
        {
            var response = await _http.PostAsJsonAsync("api/ReviewApi", review);
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<Documentary>> SearchDocumentariesAsync(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Documentary>>($"api/Documentaries/search?query={Uri.EscapeDataString(searchText)}");
        }

        public async Task<List<Documentary>> GetDocumentariesByCategoryAndSearchAsync(string category, string searchText)
        {
            return await _http.GetFromJsonAsync<List<Documentary>>(
                $"api/Documentaries/search?category={Uri.EscapeDataString(category)}&query={Uri.EscapeDataString(searchText)}");
        }
    }
}
