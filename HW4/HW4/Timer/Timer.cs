public class Timer
{
	public event Action? OnTimeElapsed;

	public void Start(int seconds)
	{
		var timer = new System.Timers.Timer(seconds * 1000);
		timer.Elapsed += (s, e) =>
		{
			timer.Stop();
			OnTimeElapsed?.Invoke();
		};

		timer.AutoReset = false;
		timer.Enabled = true;
	}
}