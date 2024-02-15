using CookiesCookbook;
using CookiesCookbook.App;
using CookiesCookbook.Recipes;

var cookiesRecipiesApp = new CookiesRecipesApp(
    new RecipesRepository(), new RecipesConsoleUserInteraction());
cookiesRecipiesApp.Run();