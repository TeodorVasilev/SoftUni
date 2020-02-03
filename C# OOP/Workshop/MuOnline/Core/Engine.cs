namespace MuOnline.Core
{
	using System;
	using Microsoft.Extensions.DependencyInjection;
	using Contracts;

	public class Engine : IEngine
	{
		private readonly IServiceProvider serviceProvider;

		public Engine(IServiceProvider serviceProvider)
		{
			this.serviceProvider = serviceProvider;
		}

		public void Run()
		{
			while (true)
			{
				try
				{

					string[] inputArgs = Console.ReadLine()
				   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

					var commandInterpreter = serviceProvider.GetService<ICommandInterpreter>();
					var result = commandInterpreter.Read(inputArgs);

					//todo add IWriter
					Console.WriteLine(result);

				}
				catch (ArgumentNullException anex)
				{
					Console.WriteLine(anex.Message);
				}
				catch (ArgumentException ax)
				{
					Console.WriteLine(ax.Message);
				}
				catch (InvalidOperationException iox)
				{
					Console.WriteLine(iox.Message);
				}
			}
		}
	}
}
