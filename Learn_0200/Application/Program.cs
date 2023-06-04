namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		//var person = new Person();

		//person.Age = 20;
		// **************************************************

		// **************************************************
		//var person = new Person();

		//person.X += Person_X;

		//person.Age = 20;
		// **************************************************

		// **************************************************
		var person = new Person();

		person.X += Person_X1;
		person.X += Person_X2;

		person.Age = 20;
		// **************************************************
	}

	private static void Person_X(object sender, System.EventArgs e)
	{
		System.Console.WriteLine
			(value: "Age value changed!");
	}

	private static void Person_X1(object sender, System.EventArgs e)
	{
		System.Console.WriteLine
			(value: "(1). Age value changed!");
	}

	private static void Person_X2(object sender, System.EventArgs e)
	{
		System.Console.WriteLine
			(value: "(2). Age value changed!");
	}
}
