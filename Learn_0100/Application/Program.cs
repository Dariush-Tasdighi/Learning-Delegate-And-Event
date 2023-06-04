namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		// **************************************************
		// Second Step: Define Delegate Instance!
		MyDelegate myDelegate;

		// Third Step: Register Some Method with Delegate Instance!
		myDelegate =
			new MyDelegate(MyClass.Function2);

		// Forth Step: Call (Run) Delegate Instance!
		myDelegate.Invoke(value: 110);
		// **************************************************

		// **************************************************
		//MyDelegate myDelegate;

		//myDelegate =
		//	new MyDelegate(MyClass.Function2);

		//// Best Practice!
		////if (myDelegate is not null)
		////{
		////	myDelegate.Invoke(value: 110);
		////}

		//myDelegate?.Invoke(value: 110);
		// **************************************************

		// **************************************************
		//MyDelegate myDelegate;

		//myDelegate = new MyDelegate(MyClass.Function1); // Wrong!
		//myDelegate = new MyDelegate(MyClass.Function2); // OK
		//myDelegate = new MyDelegate(MyClass.Function3); // Wrong!
		//myDelegate = new MyDelegate(MyClass.Function4); // Wrong!

		//var myInstance = new MyClass();

		//myDelegate = new MyDelegate(myInstance.Function5); // Wrong!
		//myDelegate = new MyDelegate(myInstance.Function6); // OK
		//myDelegate = new MyDelegate(myInstance.Function7); // Wrong!
		//myDelegate = new MyDelegate(myInstance.Function8); // Wrong!
		// **************************************************

		// **************************************************
		//MyDelegate myDelegate;
		//myDelegate =
		//	new MyDelegate(MyClass.Function2);

		//var myInstance = new MyClass();
		//myDelegate =
		//	new MyDelegate(myInstance.Function6);

		//// Note: Just Run The Last Registered Method!
		//myDelegate?.Invoke(value: 110);
		// **************************************************

		// **************************************************
		//MyDelegate myDelegate;
		//myDelegate =
		//	new MyDelegate(MyClass.Function2);

		//var myInstance = new MyClass();
		//myDelegate +=
		//	new MyDelegate(myInstance.Function6);

		//// Note: Run All of Registered Method!
		//myDelegate?.Invoke(value: 110);
		// **************************************************

		// **************************************************
		//MyDelegate myDelegate;

		//myDelegate =
		//	new MyDelegate(MyClass.Function2);

		//myDelegate +=
		//	new MyDelegate(MyClass.Function2);

		//myDelegate +=
		//	new MyDelegate(MyClass.Function2);

		//// Note: Delegate instances does not detect similar methods!
		//myDelegate?.Invoke(value: 110);
		// **************************************************

		// **************************************************
		// Simplicity in New .NET Versions
		// **************************************************
		//MyDelegate myDelegate;
		//myDelegate = MyClass.Function2;

		//var myInstance = new MyClass();
		//myDelegate += myInstance.Function6;

		//if(myDelegate is not null)
		//{
		//	myDelegate(value: 110);
		//}
		// **************************************************

		// **************************************************
		// Unregister a method from delegete
		// **************************************************
		//		MyDelegate myDelegate;
		//		myDelegate = MyClass.Function2;

		//		var myInstance = new MyClass();
		//		myDelegate += myInstance.Function6;

		//		if (myDelegate is not null)
		//		{
		//#pragma warning disable CS8601
		//			myDelegate -= MyClass.Function2;
		//#pragma warning restore CS8601
		//		}

		//		if (myDelegate is not null)
		//		{
		//			myDelegate(value: 110);
		//		}
		// **************************************************

		// **************************************************
		// Unregister a method from delegete
		// **************************************************
		//MyDelegate myDelegate1;
		//myDelegate1 = MyClass.Function2;

		//var myInstance = new MyClass();
		//MyDelegate myDelegate2;
		//myDelegate2 = MyClass.Function2;
		//myDelegate2 += myInstance.Function6;

		//MyDelegate myDelegate3 =
		//	myDelegate1 + myDelegate2;

		//if (myDelegate3 is not null)
		//{
		//	myDelegate3(value: 110);
		//}
		// **************************************************
	}
}
