using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class GroundCoffee
{
    public int Quantity { get; set; }
}

public class BrewingUnit
{
    public Coffee Brew(GroundCoffee groundCoffee)
    {
        Coffee coffee = new Coffee();
        coffee.GroundCoffee = groundCoffee;
        return coffee;
    }
}


public class GrinderUnit
{
	public GroundCoffee Grind(int quantity)
    {
        GroundCoffee groundCoffee = new GroundCoffee();
        groundCoffee.Quantity = quantity;

        return groundCoffee;
    }
}
