using CookiesCookbook;
using CookiesCookbook.App;
using CookiesCookbook.DataAccess;
using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipiesApp = new CookiesRecipesApp(
    new RecipesRepository(
        new StringTextualRepository(),
        ingredientsRegister), 
    new RecipesConsoleUserInteraction(
        ingredientsRegister)
    );
cookiesRecipiesApp.Run("recipes.txt");