namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		var stack1 = new Stack<int>();

		stack1.Push(value: 1);
		stack1.Push(value: 2);
		//stack.Push(value: "Hello, World!"); //حال دیگر نمی‌توانیم سوتی دهیم
		stack1.Push(value: 4);
		stack1.Push(value: 5);

		while (stack1.IsEmpty == false)
		{
			var value = stack1.Pop();

			var result =
				System.Convert.ToInt32(value) * 10;

			System.Console.WriteLine(value: result);
		}
		// **************************************************

		// **************************************************
		var stack2 = new Stack<string>();

		stack2.Push(value: "Ali");
		stack2.Push(value: "Reza");
		//stack.Push(value: 110); // حال دیگر نمی‌توانیم سوتی دهیم
		stack2.Push(value: "Sasan");
		stack2.Push(value: "Dariush");

		while (stack2.IsEmpty == false)
		{
			var value = stack2.Pop();

			var result =
				$"Hello, {value}!";

			System.Console.WriteLine(value: result);
		}
		// **************************************************

		// **************************************************
		var stack3 = new Stack<Person>();

		stack3.Push(value: new Person(fullName: "Sara Ahmadi", age: 30));
		stack3.Push(value: new Person(fullName: "Ali Reza Alavi", age: 40));
		stack3.Push(value: new Person(fullName: "Dariush Tasdighi", age: 50));

		//stack.Push(value: 110); // حال دیگر نمی‌توانیم سوتی دهیم
		//stack.Push(value: "Hello, World!"); // حال دیگر نمی‌توانیم سوتی دهیم

		while (stack3.IsEmpty == false)
		{
			var value = stack3.Pop();

			System.Console.WriteLine(value: value.ToString());
		}
		// **************************************************
	}
}
