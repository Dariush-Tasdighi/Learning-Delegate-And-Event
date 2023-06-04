namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static string SomeFunction(int value)
	{
		var result =
			$"The {nameof(value)} is {value}";

		return result;
	}

	private static void Main()
	{
		// **************************************************
		var myDelegate1 =
			new MyDelegate(SomeFunction);

		var result1 =
			myDelegate1?.Invoke(value: 10);

		System.Console.WriteLine(value: result1);
		// **************************************************

		// **************************************************
		// Anounymous Method
		// **************************************************
		var myDelegate2 =
			delegate (int value)
			{
				var result =
					$"The {nameof(value)} is {value}";

				return result;
			};

		var result2 =
			myDelegate2?.Invoke(arg: 10);

		System.Console.WriteLine(value: result2);
		// **************************************************

		// **************************************************
		// چرا دقیقا از جنس ذیل تعریف کردیم
		// استفاده نکردیم var و از
		MyDelegate myDelegate3 =
			delegate (int value)
			{
				var result =
					$"The {nameof(value)} is {value}";

				return result;
			};

		var result3 =
			myDelegate3?.Invoke(value: 10);

		System.Console.WriteLine(value: result3);
		// **************************************************

		// **************************************************
		// Lambda Expression
		// **************************************************
		//MyDelegate myDelegate4 = delegate (int value)
		//{
		//	var result =
		//		$"The {nameof(value)} is {value}";

		//	return result;
		//};

		//MyDelegate myDelegate4 = (int value) =>
		//{
		//	var result =
		//		$"The {nameof(value)} is {value}";

		//	return result;
		//};

		//MyDelegate myDelegate4 = (value) =>
		//{
		//	var result =
		//		$"The {nameof(value)} is {value}";

		//	return result;
		//};

		MyDelegate myDelegate4 = (value) => $"The {nameof(value)} is {value}";

		var result4 =
			myDelegate4?.Invoke(value: 10);

		System.Console.WriteLine(value: result4);
		// **************************************************

		// **************************************************
		// *** یک مثال کاربردی ******************************
		// **************************************************
		var list =
			new System.Collections.Generic.List<int>();

		for (int index = 1; index <= 10; index++)
		{
			list.Add(item: index);
		}

		//for (int index = 1; index <= 10; index++)
		//{
		//	System.Console.WriteLine(value: index);
		//}

		//foreach (var item in list)
		//{
		//	System.Console.WriteLine(value: item);
		//}

		//list.ForEach(action: DoSomething);

		//list.ForEach(action: (int item) =>
		//{
		//	System.Console.WriteLine(value: item);
		//});

		list.ForEach(action: (item) =>
		{
			System.Console.WriteLine(value: item);
		});
		// **************************************************
		// **************************************************
		// **************************************************
	}

	private static void DoSomething(int value)
	{
		System.Console.WriteLine(value: value);
	}
}
