using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class ItalianSandwich: Sandwich
    {
        List<string> meatUsed = new List<string>(){ "Salami", "Pepperoni", "Capicola Ham" };
        List<string> cheeseUsed = new List<string>() { "Provolone" };
        List<string> veggiesUsed = new List<string>() { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        List<string> condimentsUsed = new List<string>() { "Oil", "Vinegar" };
    public override void addMeat()
    {
        Console.Write("Adding the Meat: ");
        foreach (string meat in meatUsed)
        {
            Console.Write(meat + " ");
        }
    }
    public override void addCheese()
    {
        Console.Write("Adding the Cheese: ");
        foreach (string cheese in cheeseUsed)
        {
            Console.Write(cheese + " ");
        }
    }
    public override void addVegetables()
    {
        Console.Write("Adding the Vegetables: ");
        foreach (string vegetable in veggiesUsed)
        {
            Console.Write(vegetable + " ");
           
        }
    }
    public override void addCondiments()
    {
        Console.Write("Adding the Condiments: ");
        foreach (string condiment in condimentsUsed)
        {
            Console.Write(condiment + " ");
        }
    }
}}