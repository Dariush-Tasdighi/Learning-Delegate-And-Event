namespace Application;

public class Person : object
{
	public Person(string fullName, int age) : base()
	{
		Age = age;
		FullName = fullName;
	}

	public int Age { get; set; }

	public string FullName { get; set; }

	public override string ToString()
	{
		var message =
			$"{nameof(FullName)}: {FullName} - {nameof(Age)}: {Age}";

		return message;
	}
}
