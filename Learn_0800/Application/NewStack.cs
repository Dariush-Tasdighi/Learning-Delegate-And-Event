namespace Application;

public class NewStack<SomeType> : object
{
	public NewStack() : base()
	{
	}

	private System.Collections.ArrayList? _list;

	protected System.Collections.ArrayList List
	{
		get
		{
			_list ??= new System
				.Collections.ArrayList();

			return _list;
		}
	}

	public bool IsEmpty
	{
		get
		{
			return List.Count == 0 ? true : false;
		}
	}

	public void Push(SomeType value)
	{
		List.Add(value: value);
	}

	public SomeType Pop()
	{
		if (IsEmpty)
		{
			var errorMessage =
				$"Stack is Empty!";

			throw new System
				.Exception(message: errorMessage);
		}

		var result = List[^1];

		List.RemoveAt(index: List.Count - 1);

		if (result is null)
		{
			var errorMessage =
				$"Stack item is null!";

			throw new System
				.Exception(message: errorMessage);
		}

		return (SomeType)result;
	}
}
