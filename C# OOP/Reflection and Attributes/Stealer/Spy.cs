namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

	public class Spy
	{
        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            var sb = new StringBuilder();
            var targetType = Type.GetType(className);

            sb.AppendLine($"Class under investigation: {targetType}");

            var classInstance = Activator.CreateInstance(targetType);

            var fields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var field in fields.Where(f => fieldsNames.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            var classType = Type.GetType(className);

            var fieldInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            var classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            foreach (var field in fieldInfo)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in classPrivateMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            var classType = Type.GetType(className);

            var methodInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            sb.AppendLine($"All private methods of Class: {className}");
            sb.AppendLine($"Base class: {classType.BaseType.Name}");

            foreach (var method in methodInfo)
            {
                sb.AppendLine($"{method.Name}");
            }

            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            var classType = Type.GetType(className);

            var methodInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            var sb = new StringBuilder();

            foreach (var method in methodInfo.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in methodInfo.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}
