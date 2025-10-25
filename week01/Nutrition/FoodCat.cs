public class FoodCat
{
    string _name;
    int _code;
    string _mainCode;



    public FoodCat(string name, int code, string mainCode)
    {
        _name = name;
        _code = code;
        _mainCode = mainCode;

    }
    
    public void PrintFoodCat()
    {
        Console.WriteLine($"{_name} --  {_code} -- {_mainCode}");
    }
}