namespace Application;

internal class MyClass : object
{
	static MyClass()
	{
	}

	public static void Function1()
	{
		//var message =
		//	$"Function: Function1 has been run!";

		var message =
			$"Function: {nameof(Function1)} has been run!";

		System.Console.WriteLine(value: message);
	}

	public static void Function2(int value)
	{
		var message =
			$"Function: {nameof(Function2)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);
	}

	public static void Function3(string value)
	{
		var message =
			$"Function: {nameof(Function3)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);
	}

	public static string Function4(int value)
	{
		var message =
			$"Function: {nameof(Function4)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);

		return message;
	}

	public MyClass() : base()
	{
	}

	public void Function5()
	{
		var message =
			$"Function: {nameof(Function5)} has been run!";

		System.Console.WriteLine(value: message);
	}

	public void Function6(int value)
	{
		var message =
			$"Function: {nameof(Function6)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);
	}

	public void Function7(string value)
	{
		var message =
			$"Function: {nameof(Function7)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);
	}

	public string Function8(string value)
	{
		var message =
			$"Function: {nameof(Function8)} has been run! Value: {value}";

		System.Console.WriteLine(value: message);

		return message;
	}
}
