class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;


    public Food(string name, int calories, bool isSpicy, bool isSweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweet = isSweet;
    }
    public void PrintFood()
    {
        Console.WriteLine($"Name :{Name}");
        Console.WriteLine($"Calories :{Calories}");
        Console.WriteLine($"IsSpicy :{IsSpicy}");
        Console.WriteLine($"IsSweet :{IsSweet}");
    }

}


