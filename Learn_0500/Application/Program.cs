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

		person.AgeChanging += Person_AgeChanging;

		person.Age = 20;
		person.ShowInformation();

		person.Age = 60;
		person.ShowInformation();

		person.Age = 30;
		person.ShowInformation();
		// **************************************************
	}

	private static void Person_AgeChanging(object sender, AgeEventArgs e)
	{
		if(e.NewValue > 50)
		{
			// بی‌خیال شو = شتر دیدی ندیدی
			e.Cancel = true;
		}
	}
}
