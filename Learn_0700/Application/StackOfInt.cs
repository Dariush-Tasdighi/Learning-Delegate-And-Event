namespace Application;

public class StackOfInt : object
{
	public StackOfInt() : base()
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

	public void Push(int value)
	{
		List.Add(value: value);
	}

	public int Pop()
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

		return (int)result;
	}
}
