using CookiesCookbook;
using CookiesCookbook.App;
using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

var cookiesRecipiesApp = new CookiesRecipesApp(
    new RecipesRepository(), new RecipesConsoleUserInteraction(new IngredientsRegister()));
cookiesRecipiesApp.Run("recipes.txt");