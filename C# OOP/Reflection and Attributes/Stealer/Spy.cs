namespace Stealer
{
    using System.Reflection;
    using System.Text;

	public class Spy
	{
		public string StealFieldInfo(string name, params string[] fieldsNames)
		{
			var sb = new StringBuilder();

			sb.AppendLine($"Class under investigation: {nameof(Hacker)}");

			var fields = typeof(Hacker).GetFields(BindingFlags.NonPublic);

			return sb.ToString();
		}
	}
}
