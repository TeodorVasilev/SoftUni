namespace Stealer
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			var spy = new Spy();
			var result = spy.StealFieldInfo(typeof(Hacker).FullName, "username", "password");
			Console.WriteLine(result);

			var acessModifiersResult = spy.AnalyzeAcessModifiers(typeof(Hacker).FullName);
			Console.WriteLine(acessModifiersResult);

			var privateMethodsResult = spy.RevealPrivateMethods(typeof(Hacker).FullName);
			Console.WriteLine(privateMethodsResult);

			var collectResult = spy.CollectGettersAndSetters(typeof(Hacker).FullName);
			Console.WriteLine(collectResult);
		}
	}
}
