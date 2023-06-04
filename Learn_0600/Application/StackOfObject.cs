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

	private System.Collections.ArrayList? _list;

	public System.Collections.ArrayList List
	{
		get
		{
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
			return List.Count == 0 ? true : false;
		}
	}

	public void Push(object value)
	{
		List.Add(value: value);
	}

	public object Pop()
	{
		if (List.Count == 0)
		{
			var errorMessage =
				$"Stack is Empty!";

			throw new System
				.Exception(message: errorMessage);
		}

		var result = List[^1];

		//var result =
		//	List[List.Count - 1];

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
