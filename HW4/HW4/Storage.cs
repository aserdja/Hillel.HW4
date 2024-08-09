namespace HW4
{
	public class Storage<T>
	{
		private static T? Instance { get; set; }

		public void SetItem(T item)
		{
			Instance = item;
		}

		public T? GetItem()
		{
			return Instance;
		}
	}
}
