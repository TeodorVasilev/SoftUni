namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

	public class Spy
	{
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType(className);
            var instance = Activator.CreateInstance(type, new object[0]);

            sb.AppendLine($"Class under investigation: {className}");
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static |
                                                BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var field in fields.Where(field => fieldNames.Contains(field.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }

            return sb.ToString().Trim();
        }
    }
}
