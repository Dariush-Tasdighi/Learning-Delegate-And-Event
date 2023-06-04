namespace Application;

//public class AgeEventArgs : System.EventArgs
//{
//	public AgeEventArgs() : base()
//	{
//	}

//	public int OldValue { get; set; }

//	public int CurrentValue { get; set; }
//}

/// <summary>
/// Step Zeor!
/// </summary>
public class AgeEventArgs : System.EventArgs
{
	public AgeEventArgs(int oldValue, int currentValue) : base()
	{
		OldValue = oldValue;
		CurrentValue = currentValue;
	}

	public int OldValue { get; init; }

	public int CurrentValue { get; init; }
}
