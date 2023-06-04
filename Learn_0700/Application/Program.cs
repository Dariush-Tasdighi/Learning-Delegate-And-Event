namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		//var stack = new StackOfInt();

		//stack.Push(value: 1);
		//stack.Push(value: 2);
		////stack.Push(value: "Hello, World!"); //حال دیگر نمی‌توانیم سوتی دهیم
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
		// حال مشکل چیست؟
		// با این نگاه، باید به ازای هر نوعی که می‌خواهیم
		// یک کلاس تخصصی برای آن تایپ خلق نماییم
		// **************************************************

		// **************************************************
		//var stack = new StackOfString();

		//stack.Push(value: "Ali");
		//stack.Push(value: "Reza");
		////stack.Push(value: 110); // حال دیگر نمی‌توانیم سوتی دهیم
		//stack.Push(value: "Sasan");
		//stack.Push(value: "Dariush");

		//while (stack.IsEmpty == false)
		//{
		//	var value = stack.Pop();

		//	var result =
		//		$"Hello, {value}!";

		//	System.Console.WriteLine(value: result);
		//}
		// **************************************************

		// **************************************************
		var stack = new StackOfPerson();

		stack.Push(value: new Person(fullName: "Sara Ahmadi", age: 30));
		stack.Push(value: new Person(fullName: "Ali Reza Alavi", age: 40));
		stack.Push(value: new Person(fullName: "Dariush Tasdighi", age: 50));

		//stack.Push(value: 110); // حال دیگر نمی‌توانیم سوتی دهیم
		//stack.Push(value: "Hello, World!"); // حال دیگر نمی‌توانیم سوتی دهیم

		while (stack.IsEmpty == false)
		{
			var value = stack.Pop();

			System.Console.WriteLine(value: value.ToString());
		}
		// **************************************************
	}
}
