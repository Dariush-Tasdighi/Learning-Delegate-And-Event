namespace Application;

public class Person : object
{
	public Person() : base()
	{
	}

	// 2th Step!
	public event AgeChangingHandler? AgeChanging;

	//public int Age { get; set; }

	private int _age;

	public int Age
	{
		get
		{
			return _age;
		}
		set
		{
			var ageEventArgs = new AgeEventArgs
				(currentValue: _age, newValue: value);

			// 4th Step!
			OnAgeChanging(e: ageEventArgs);

			if(ageEventArgs.Cancel == false)
			{
				_age = value;
			}
		}
	}

	// 3th Step!
	protected virtual void OnAgeChanging(AgeEventArgs e)
	{
		if (AgeChanging is not null)
		{
			AgeChanging(sender: this, e: e);
		}
	}

	public void ShowInformation()
	{
		System.Console.WriteLine(value: $"I'm {Age} years old!");
	}
}
