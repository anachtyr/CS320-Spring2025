using Microsoft.AspNetCore.Mvc;
using MyCookbookApp.Services;
using System.Threading.Tasks;
namespace MyCookbookApp.Controllers
{
    public class RecipeController : Controller
    {
        private readonly RecipeService _recipeService;
        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        public async Task<IActionResult> Index()
        {
            var recipes = await _recipeService.GetRecipesAsync();
            return View(recipes);
        }
    }
}