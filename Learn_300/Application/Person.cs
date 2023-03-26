namespace Application;

public class Person : object
{
	public Person() : base()
	{
	}

	// 2th Step!
	public event AgeChangedHandler? AgeChanged;

	public string? FullName { get; set; }

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
			_age = value;

			// 4th Step!
			OnAgeChanged(e: new System.EventArgs());
		}
	}

	// 3th Step!
	protected virtual void OnAgeChanged(System.EventArgs e)
	{
		if (AgeChanged is not null)
		{
			AgeChanged(sender: this, e: e);
		}
	}
}
