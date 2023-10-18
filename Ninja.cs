class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;

    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }

    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }

    // build out the Eat method
    public void Eat(Food item)
    {
        if (!IsFull)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"Food: {item.Name}!");
            if (item.IsSpicy)
                Console.WriteLine($"Food: {item.Name}, Spicy: yes");
            if (item.IsSweet)
                Console.WriteLine($"Food: {item.Name}, Sweet: yes");
        }
        else
        {
            Console.WriteLine("Ninja is full");
        }
    }
}

