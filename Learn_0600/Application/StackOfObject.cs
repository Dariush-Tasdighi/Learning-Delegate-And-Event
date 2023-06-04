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
			if (_list is null)
			{
				_list = new System.Collections.ArrayList();
			}

			return _list;
		}
	}

	public void Push(object value)
	{
		List.Add(value: value);
	}

	public object? Pop()
	{
		//if( List is null)
		//{
		//	return null;
		//}

		if (List.Count == 0)
		{
			return null;
		}

		var result =
			List[List.Count - 1];

		List.RemoveAt(index: List.Count - 1);

		return result;
	}
}
