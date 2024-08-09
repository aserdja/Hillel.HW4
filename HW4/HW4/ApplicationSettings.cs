namespace HW4
{
	public class ApplicationSettings
	{
		public string Name { get; private set; } = "Homework Application";
		public string Version { get; private set; } = "1.2";

		public string GetApplicationInfo()
		{
			var temp = new DatabaseSettings();
			return $"Application Name: {Name} \nVersion: {Version} \nDatabase info:" +
				$" \nConnection string: {temp.ConnectionString}{temp.Timeout}";
		}

		private class DatabaseSettings
		{
			public string ConnectionString { get; private set; } = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;";
			public string Timeout { get; private set; } = "Connect Timeout=30;";

		}
	}
}
