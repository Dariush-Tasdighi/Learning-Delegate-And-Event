namespace Application;

public class MyClass : object
{
	public MyClass() : base()
	{
	}

	public void Function1()
	{
		var message =
			$"Function: {nameof(Function1)} has been run!";

		System.Console.WriteLine(value: message);
	}

	public void Function2(int value)
	{
		var message =
			$"Function: {nameof(Function2)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);
	}

	public bool Function3()
	{
		var message =
			$"Function: {nameof(Function3)} has been run!";

		System.Console.WriteLine(value: message);

		return true;
	}

	public bool Function4(int value)
	{
		var message =
			$"Function: {nameof(Function4)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);

		return true;
	}

	public string Function5()
	{
		var message =
			$"Function: {nameof(Function5)} has been run!";

		System.Console.WriteLine(value: message);

		return message;
	}

	public string Function6(int value)
	{
		var message =
			$"Function: {nameof(Function6)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);

		return message;
	}
}
