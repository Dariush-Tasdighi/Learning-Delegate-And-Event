namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		var person = new Person();

		person.AgeChanged += Person_AgeChanged;

		person.Age = 20;
		person.Age = 30;
		// **************************************************
	}

	private static void Person_AgeChanged(object sender, AgeEventArgs e)
	{
		System.Console.WriteLine
			(value: $"Old Value: {e.OldValue} - Current Value: {e.CurrentValue}");
	}
}
