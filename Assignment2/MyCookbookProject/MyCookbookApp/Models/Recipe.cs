namespace MyCookbookApp.Models
{
 public class Recipe
 {
    public string Name { get; set; } = "";
    public List<string> Ingredients { get; set; } = new List<string>();
    public string Steps { get; set; } = "";
 }
}