namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		//var stack = new StackOfObject();

		//stack.Push(value: 1);
		//stack.Push(value: 2);
		//stack.Push(value: 3);
		//stack.Push(value: 4);
		//stack.Push(value: 5);

		//var value1 = stack.Pop();

		//while (value1 is not null)
		//{
		//	var result =
		//		(int)value1 * 10;

		//	System.Console.WriteLine(value: result);

		//	value1 = stack.Pop();
		//}
		// **************************************************

		// **************************************************
		// حال ایراد این کلاس چیست؟
		// **************************************************

		// **************************************************
		var stack = new StackOfObject();

		stack.Push(value: 1);
		stack.Push(value: 2);
		stack.Push(value: "Hello, World!"); // سوتی
		stack.Push(value: 4);
		stack.Push(value: 5);

		var value2 = stack.Pop();

		while (value2 is not null)
		{
			var result =
				(int)value2 * 10;

			System.Console.WriteLine(value: result);

			value2 = stack.Pop();
		}
		// **************************************************
	}
}
