using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Container
{
	int _capasity = 0;
	int _value = 0;
	public Container(int capasity)
	{
		if (capasity < 0) throw new ArgumentException("Объём контейнера не может быть отрицательным");

		_capasity = capasity;
	}
	public void LoadResource(int value)
    {
		if (_value + value > _capasity || value < 0) throw new ArgumentException("Переполнение контейнера");

		_value += value;
    }
	public void GetResource(int value)
    {
		if (_value - value < 0 || value < 0) throw new ArgumentException("Недостаточно ресурсов");

		_value -= value;

		//return value;
    }
	public int GetCapasity()
    {
		return _capasity;
    }
	public int GetValue()
    {
		return _value;
    }
}
