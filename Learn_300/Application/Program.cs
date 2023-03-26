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
		// **************************************************
	}

	private static void Person_AgeChanged(object sender, System.EventArgs e)
	{
		System.Console.WriteLine
			(value: "Age value changed!");
	}
}
