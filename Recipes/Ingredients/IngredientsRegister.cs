namespace CookiesCookbook.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>()
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamom(),
        new CocoaPowder()
    };

    public Ingredient GetById(int id)
    {
        return All.FirstOrDefault(ingredient => ingredient.Id == id);
    }
}