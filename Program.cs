using CookiesCookbook;
using CookiesCookbook.App;
using CookiesCookbook.DataAccess;
using CookiesCookbook.FileAccess;
using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

const EFileFormat Format = EFileFormat.Json;

IStringsRepository stringsRepository = Format == EFileFormat.Json
    ? new StringJsonRepository()
    : new StringTextualRepository();

const string FileName = "recipes";

var fileMetaData = new FileMetaData(FileName, Format);

var ingredientsRegister = new IngredientsRegister();

var cookiesRecipiesApp = new CookiesRecipesApp(
    new RecipesRepository(
        stringsRepository,
        ingredientsRegister), 
    new RecipesConsoleUserInteraction(
        ingredientsRegister)
    );
cookiesRecipiesApp.Run(fileMetaData.ToPath());