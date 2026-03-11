Coffee[] menu = {
    new("Espresso", 0, 30, 100, 10),
    new("Double Espresso", 0, 60, 150, 25),
    new("Short Macchiato", 60, 30, 80, 40),
    new("Long Macchiato", 80, 50, 60, 70),
    new("Cappuccino", 60, 60, 40, 90)
};

// Print the menu
Console.WriteLine("=====Menu====");
for (int i = 0; i < menu.Length; i++)
{
    Console.WriteLine($"{i + 1}. {menu[i].Name}");
}
Console.WriteLine();

// Get input from the user and check if input is correct
Console.Write("Which coffee would you want? (1-5): ");
if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 5)
{
    Coffee selected = menu[choice - 1];
    selected.DisplayInfo();
} else
{
    Console.WriteLine("Invalid input! Please try again: ");
}

class Coffee
{
    public string Name { get; set; }
    public int Milk { get; set; }
    public int Water { get; set; }
    public int Beans { get; set; }
    public int Time { get; set; }

    public Coffee(string name, int milk, int water, int beans, int time)
    {
        Name = name;
        Milk = milk;
        Water = water;
        Beans = beans;
        Time = time;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Your coffee: {this.Name}");
        Console.WriteLine($"Milk: {this.Milk} ml.");
        Console.WriteLine($"Water: {this.Water} ml.");
        Console.WriteLine($"Beans: {this.Beans} beans");

        // Format the preparation time
        int minutes = this.Time / 60;
        int seconds = this.Time % 60;

        if (minutes > 0)
            Console.WriteLine($"Time: {minutes} minute(s) and {seconds} seconds");
        else
            Console.WriteLine($"Time: {seconds} seconds");
    }
}