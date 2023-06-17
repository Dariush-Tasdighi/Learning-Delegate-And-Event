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

		//while (stack.IsEmpty == false)
		//{
		//	var value = stack.Pop();

		//	var result =
		//		System.Convert.ToInt32(value) * 10;

		//	System.Console.WriteLine(value: result);
		//}
		// **************************************************

		// **************************************************
		// حال ایراد این کلاس چیست؟
		// **************************************************

		// **************************************************
		var stack = new StackOfObject();

		stack.Push(value: 1);
		stack.Push(value: 2);
		stack.Push(value: "Hello, World!"); //سوتی می‌دهیم
		stack.Push(value: 4);
		stack.Push(value: 5);

		while (stack.IsEmpty == false)
		{
			var value = stack.Pop();

			var result =
				System.Convert.ToInt32(value) * 10;

			System.Console.WriteLine(value: result);
		}
		// **************************************************

		// **************************************************
		// ما باید از
		// String and Object
		// همیشه فرار کنیم
		// string: KeyName: "FulName" -> "FullName"
		//
		// Strongly Typed!!!
		// **************************************************
	}
}
