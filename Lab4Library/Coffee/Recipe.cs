using System;
public class Recipe
{
	public int Water { get; private set; }
	public int Milk  { get; private set; }
	public int Beans { get; private set; }

	public Recipe(int water, int milk, int beans)
	{
		if (water < 0 || milk < 0 || beans < 0) 
			throw new ArgumentException("Значения не могут быть отрицательными");
		Water = water;
		Milk = milk;	
		Beans = beans;
	}
}
