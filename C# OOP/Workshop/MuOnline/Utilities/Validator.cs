namespace MuOnline.Utilities
{
	using System;

	public static class Validator
	{
		public static void ValidateLessThanZero(int value, string objectName)
		{
			if(value < 0)
			{
				throw new ArgumentException($"{objectName} cannot be less than zero");
			}
		}
	}
}
