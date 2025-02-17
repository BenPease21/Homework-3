using System;

class Program
{
    enum SoupType { Soup, Stew, Gumbo }
    enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes }
    enum Seasoning { Spicy, Salty, Sweet }

    static void Main()
    {
        Console.WriteLine("Welcome to Simula's Soup Maker!\n");

        Console.WriteLine("Choose a type: Soup, Stew, or Gumbo:");
        string SoupInput = Console.ReadLine();
        Console.WriteLine("Choose a main ingredient: Mushrooms, Chicken, Carrots, or Potatoes:");
        string IngredientInput = Console.ReadLine();
        Console.WriteLine("Choose a seasoning: Spicy, Salty, or Sweet:");
        string SeasoningInput = Console.ReadLine();

        var soup = ($"{SeasoningInput} {IngredientInput} {SoupInput} ");

        Console.WriteLine($"You made: {soup}!");
    }
}