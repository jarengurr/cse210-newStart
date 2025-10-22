using System.Diagnostics.Contracts;

public class CookingMethod
{
    string _cookingType;
    string _code;


    public CookingMethod(string cookType, string code)
    {
        _code = code;
        _cookingType = cookType;
    }
}