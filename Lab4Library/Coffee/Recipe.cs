using System;
public class Recipe
{
	public int Water { get; set; }
	public int Milk  { get; set; }
	public int Beans { get; set; }

	public Recipe(int water, int milk, int beans)
	{
		if (water < 0 || milk < 0 || beans < 0) throw new ArgumentException("Значения не могут быть отрицательными");
		Water = water;
		Milk = milk;	
		Beans = beans;
	}
}
