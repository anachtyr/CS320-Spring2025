using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MyCookbookApp.Models;
using System.Collections.Generic;

namespace MyCookbookApp.Services
{
    public class RecipeService
    {
        private readonly HttpClient _httpClient;
        public RecipeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:5208/api/recipe");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            return recipes ?? new List<Recipe>();
        }
    }
}