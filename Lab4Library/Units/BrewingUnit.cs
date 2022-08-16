using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class BrewingUnit
{
    public Coffee Brew(GroundCoffee groundCoffee)
    {
        Coffee coffee = new Coffee();
        coffee.GroundCoffee = groundCoffee;
        return coffee;
    }
}
