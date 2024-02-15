namespace CookiesCookbook.Recipes;

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}