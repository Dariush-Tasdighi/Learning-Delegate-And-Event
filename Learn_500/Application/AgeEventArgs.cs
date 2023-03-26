namespace Application;

/// <summary>
/// Step Zeor!
/// </summary>
public class AgeEventArgs : System.EventArgs
{
	public AgeEventArgs(int currentValue, int newValue) : base()
	{
		NewValue = newValue;
		CurrentValue = currentValue;
	}

	public int CurrentValue { get; init; }

	public int NewValue { get; init; }

	public bool Cancel { get; set; }
}
