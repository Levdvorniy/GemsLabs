using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class GrinderUnit
{
    public GroundCoffee Grind(int quantity)
    {
        GroundCoffee groundCoffee = new GroundCoffee();
        groundCoffee.Quantity = quantity;

        return groundCoffee;
    }
}
