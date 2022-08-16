using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Container
{
	int _capacity = 0;
	int _value = 0;
	public Container(int capacity)
	{
		if (capacity < 0) 
			throw new ArgumentException("Объём контейнера не может быть отрицательным");

		_capacity = capacity;
	}
	public void LoadResource(int value)
    {
		if (_value + value > _capacity || value < 0) 
			throw new ArgumentException("Переполнение контейнера");

		_value += value;
    }
	public void GetResource(int value)
    {
		if (_value - value < 0 || value < 0) 
			throw new ArgumentException("Недостаточно ресурсов");

		_value -= value;

    }
	public int GetCapasity()
    {
		return _capacity;
    }
	public int GetValue()
    {
		return _value;
    }
}
