namespace Application;

public class Person : object
{
	public Person() : base()
	{
	}

	// 2th Step!
	public event XHandler? X;

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
			OnX(e: new System.EventArgs());
		}
	}

	// 3th Step!
	protected virtual void OnX(System.EventArgs e)
	{
		if (X is not null)
		{
			X(sender: this, e: e);
		}
	}
}
