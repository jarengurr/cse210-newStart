using System.Security.Cryptography.X509Certificates;

public class FoodStuffs : Food
{
    string _scientificName;
    private List<Nutrient> theNutrient = new List<Nutrient>();
    private List<Chemical> theChem = new List<Chemical>();
    private List<CookingMethod> theCookMethod = new List<CookingMethod>();
    private List<Ingredient> theIngredient = new List<Ingredient>();
    private List<Diet> theDiet = new List<Diet>();
    private List<Cuisine> theCuisine = new List<Cuisine>();

    public FoodStuffs(string name, Int64 aCode, string sName = "") : base(name, aCode)
    {
        base._code = aCode;
        base._name = name;
        _scientificName = sName;
    }
    
}