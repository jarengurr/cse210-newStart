
using System;

class Program
{



    static void Main(string[] args)
    {
        string hold = "Solar Oven";
        string holdnum = "001";

        List<CookingMethod> cookingMethods = new List<CookingMethod>();
        
        CookingMethod cookingMethod = new CookingMethod(hold, holdnum);
        CookingMethod cookingMethod2 = new CookingMethod("MicroWave Oven", "002");
        CookingMethod cookingMethod3 = new CookingMethod("Gas Oven", "003");
        CookingMethod cookingMethod4 = new CookingMethod("Electric Oven", "004");
        CookingMethod cookingMethod5 = new CookingMethod("Camp Fire", "005");
        CookingMethod cookingMethod6 = new CookingMethod("Pressure Cooker", "006");
        CookingMethod cookingMethod7 = new CookingMethod("Crock Pot", "007");
        CookingMethod cookingMethod8 = new CookingMethod("Steaming", "008");
        CookingMethod cookingMethod9 = new CookingMethod("Deep Frying", "009");
        CookingMethod cookingMethod10 = new CookingMethod("Air Frying", "010");
        CookingMethod cookingMethod11 = new CookingMethod("Roasting", "011");
        CookingMethod cookingMethod12 = new CookingMethod("Baking", "012");
        CookingMethod cookingMethod13 = new CookingMethod("Sauteeing", "013");
        CookingMethod cookingMethod14 = new CookingMethod("Broiling", "014");
        CookingMethod cookingMethod15 = new CookingMethod("Grilling", "015");
        CookingMethod cookingMethod16 = new CookingMethod("Dehydrating", "016");
        CookingMethod cookingMethod17 = new CookingMethod("Poaching", "017");
        CookingMethod cookingMethod18 = new CookingMethod("Simmering", "018");
        CookingMethod cookingMethod19 = new CookingMethod("Boiling", "019");
        CookingMethod cookingMethod20 = new CookingMethod("Braising", "020");
        CookingMethod cookingMethod21 = new CookingMethod("Stewing", "021");
        CookingMethod cookingMethod22 = new CookingMethod("Pot Roasting", "022");
        CookingMethod cookingMethod23 = new CookingMethod("Picklilng", "023");
        CookingMethod cookingMethod24 = new CookingMethod("Toasting", "024");
        CookingMethod cookingMethod25 = new CookingMethod("Griddlling", "025");

        cookingMethods.Add(cookingMethod);
        cookingMethods.Add(cookingMethod2);
        cookingMethods.Add(cookingMethod3);
        cookingMethods.Add(cookingMethod4);
        cookingMethods.Add(cookingMethod5);
        cookingMethods.Add(cookingMethod6);
        cookingMethods.Add(cookingMethod7);
        cookingMethods.Add(cookingMethod8);
        cookingMethods.Add(cookingMethod9);
        cookingMethods.Add(cookingMethod10);
        cookingMethods.Add(cookingMethod11);
        cookingMethods.Add(cookingMethod12);
        cookingMethods.Add(cookingMethod13);
        cookingMethods.Add(cookingMethod14);
        cookingMethods.Add(cookingMethod15);
        cookingMethods.Add(cookingMethod16);
        cookingMethods.Add(cookingMethod17);
        cookingMethods.Add(cookingMethod18);
        cookingMethods.Add(cookingMethod19);
        cookingMethods.Add(cookingMethod20);
        cookingMethods.Add(cookingMethod21);
        cookingMethods.Add(cookingMethod22);
        cookingMethods.Add(cookingMethod23);
        cookingMethods.Add(cookingMethod24);
        cookingMethods.Add(cookingMethod25);



        FoodCat myCat = new FoodCat("Solar Oven", 6, "0001");
        myCat.PrintFoodCat();



        List<Allergy> myAllergy = new List<Allergy>();


        //FoodCat theFoodCat = new FoodCat();

        Console.WriteLine("It made it");

    }
}