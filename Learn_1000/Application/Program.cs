namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	/// <summary>
	/// Learning Generic Delegate Types
	///		Action		(Generic: 16 Types and Non Generic)
	///		Predicate	(Generic: 1 Type)
	///		Func		(Generic: 17 Types)
	/// </summary>
	private static void Main()
	{
		// **************************************************
		// **************************************************
		// **************************************************
		var theObject1 = new MyClass();

		// public delegate void Action();
		//System.Action myDelegate1 =
		//	new System.Action(theObject1.Function1);

		//var myDelegate1 =
		//	new System.Action(theObject1.Function1);

		var myDelegate1 =
			theObject1.Function1;

		//myDelegate1();

		myDelegate1?.Invoke();
		// **************************************************

		// **************************************************
		var theObject2 = new MyClass();

		// public delegate void Action<in T>(T obj);
		//var myDelegate2 =
		//	new System.Action<int>(theObject2.Function2);

		var myDelegate2 =
			theObject2.Function2;

		myDelegate2?.Invoke(obj: 10);
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		var theObject3 = new MyClass();

		// public delegate bool Predicate<in T>(T obj);
		// Note: دستور ذیل کار نمی‌کند
		//var myDelegate3 =
		//	new System.Predicate(theObject3.Function3);

		var myDelegate3 =
			theObject2.Function3;

		var result3 =
			myDelegate3?.Invoke();
		// **************************************************

		// **************************************************
		var theObject4 = new MyClass();

		// public delegate bool Predicate<in T>(T obj);
		var myDelegate4 =
			new System.Predicate<int>(theObject4.Function4);

		// Note: دستور ذیل مناسب نمی‌باشد
		// Because: Compiler detect Func! not Predicate!
		//var myDelegate4 =
		//	theObject4.Function4;

		var result4 =
			myDelegate4?.Invoke(obj: 10);
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		var theObject5 = new MyClass();

		// 	public delegate TResult Func<out TResult>();
		//var myDelegate5 =
		//	new System.Func<string>(theObject5.Function5);

		var myDelegate5 =
			theObject5.Function5;

		var result5 =
			myDelegate5?.Invoke();
		// **************************************************

		// **************************************************
		var theObject6 = new MyClass();

		// 	public delegate TResult Func<out TResult>();
		//var myDelegate6 =
		//	new System.Func<int, string>(theObject6.Function6);

		var myDelegate6 =
			theObject6.Function6;

		var result6 =
			myDelegate6?.Invoke(arg: 10);
		//// **************************************************
	}
}
