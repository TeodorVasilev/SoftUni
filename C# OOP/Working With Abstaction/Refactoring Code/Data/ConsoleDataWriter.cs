namespace Refactoring_Code.Data
{
	using System;
	
	public class ConsoleDataWriter : IDataWriter
	{
		public void Write(object obj)
		{
			Console.WriteLine(obj);
		}
	}
}
