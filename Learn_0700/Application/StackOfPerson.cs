namespace Application;

public class StackOfPerson : object
{
	public StackOfPerson() : base()
	{
	}

	private System.Collections.ArrayList? _list;

	public System.Collections.ArrayList List
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

	public void Push(Person value)
	{
		List.Add(value: value);
	}

	public Person Pop()
	{
		if (List.Count == 0)
		{
			var errorMessage =
				$"Stack is Empty!";

			throw new System
				.Exception(message: errorMessage);
		}

		var result =
			List[^1] as Person;

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
