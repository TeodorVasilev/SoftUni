namespace Refactoring_Code
{
	using Commands;
	using Data;
	using Students;

	public class Program
	{
		public static void Main(string[] args)
		{
			var commandParser = new CommandParser();
			var studentSystem = new StudentSystem();
			var dataReader = new ConsoleDataReader();
			var dataWriter = new ConsoleDataWriter();

			var engine = new Engine(commandParser, studentSystem, dataReader, dataWriter);

			engine.Run();
		}
	}
}
