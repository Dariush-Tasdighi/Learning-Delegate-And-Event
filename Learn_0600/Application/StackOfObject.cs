namespace Application;

public class StackOfObject : object
{
	public StackOfObject() : base()
	{
		//List = new System.Collections.ArrayList();
	}

	/// <summary>
	/// ایراد دستور ذیل در چیست؟
	/// </summary>
	//public System.Collections.ArrayList List;

	/// <summary>
	/// ایراد دستور ذیل در چیست؟
	/// </summary>
	//public System.Collections.ArrayList List { get; set; }

	/// <summary>
	/// ایراد دستور ذیل در چیست؟
	/// </summary>
	//public System.Collections.ArrayList List { get; private set; }

	/// <summary>
	/// ایراد دستور ذیل در چیست؟
	/// </summary>
	//public System.Collections.ArrayList List { get; init; }

	/// <summary>
	/// ایراد دستور ذیل در چیست؟
	/// </summary>
	//private System.Collections.ArrayList List { get; init; }

	/// <summary>
	/// ایراد دستور ذیل در چیست؟
	/// </summary>
	////protected System.Collections.ArrayList List { get; }
	//protected System.Collections.ArrayList List { get; init; }

	/// <summary>
	/// Lazy Loading - Lazy Initialization
	/// </summary>
	private System.Collections.ArrayList? _list;

	/// <summary>
	/// Lazy Loading - Lazy Initialization
	/// </summary>
	protected System.Collections.ArrayList List
	{
		get
		{
			//if (_list == null)
			//{
			//	_list = new System
			//		.Collections.ArrayList();
			//}

			//if (_list is null)
			//{
			//	_list = new System
			//		.Collections.ArrayList();
			//}

			_list ??= new System
				.Collections.ArrayList();

			return _list;
		}
	}

	//public bool IsEmpty
	//{
	//	get
	//	{
	//		var result =
	//			List.Count;

	//		if (result == 0)
	//		{
	//			return true;
	//		}
	//		else
	//		{
	//			return false;
	//		}
	//	}
	//}

	public bool IsEmpty
	{
		get
		{
			// Inline Condition
			return List.Count == 0 ? true : false;
		}
	}

	public void Push(object value)
	{
		List.Add(value: value);
	}

	public object Pop()
	{
		if (IsEmpty)
		{
			var errorMessage =
				$"Stack is Empty!";

			throw new System
				.Exception(message: errorMessage);
		}

		//var result =
		//	List[List.Count - 1];

		var result = List[^1];

		List.RemoveAt(index: List.Count - 1);

		if (result is null)
		{
			var errorMessage =
				$"Stack item is null!";

			throw new System
				.Exception(message: errorMessage);
		}

		return result;
	}
}
