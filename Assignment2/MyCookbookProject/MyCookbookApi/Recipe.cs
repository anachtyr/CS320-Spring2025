namespace MyCookbookApi.Models
{
 public class Recipe
 {
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public string Steps { get; set; }
    //public string Category { get; set; }
    //public string PrepTime { get; set; }
 }
}