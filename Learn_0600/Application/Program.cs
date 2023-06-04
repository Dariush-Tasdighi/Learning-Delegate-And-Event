namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		var stack1 = new Stack1();

		stack1.Push(value: 1);
		stack1.Push(value: 2);
		stack1.Push(value: 3);
		stack1.Push(value: 4);
		stack1.Push(value: 5);

		var value1 = stack1.Pop();

		while (value1 is not null)
		{
			var result =
				(int)value1 * 10;

			System.Console.WriteLine(value: result);

			value1 = stack1.Pop();
		}
		// **************************************************

		// **************************************************
		// حال ایراد این کلاس چیست؟
		// **************************************************

		// **************************************************
		//var stack2 = new Stack1();

		//stack2.Push(value: 1);
		//stack2.Push(value: 2);
		//stack2.Push(value: "Hello, World!"); // سوتی
		//stack2.Push(value: 4);
		//stack2.Push(value: 5);

		//var value2 = stack2.Pop();

		//while (value2 is not null)
		//{
		//	var result =
		//		(int)value2 * 10;

		//	System.Console.WriteLine(value: result);

		//	value2 = stack2.Pop();
		//}
		// **************************************************
	}
}
