using CookiesCookbook.Recipes;

namespace CookiesCookbook.App;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Any())
        {
            Console.WriteLine($"Existing recipes are: {Environment.NewLine}");

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"******{counter}*******");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
    }
}