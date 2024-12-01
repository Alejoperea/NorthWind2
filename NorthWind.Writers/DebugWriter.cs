namespace NorthWind.Writers
{
	public class DebugWriter : IUserActionWriter
	{
		public void Writer(UserAction action)
		{
			Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}",
				action.CreateDateTime, action.User, action.Description);
		}
	}
}
