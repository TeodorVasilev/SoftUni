using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05._Date_Modifier
{
	public class DateModifier
	{
		public int CalculateDayDiffrence(string firstDate, string secondDate)
		{
			var firstDateArr = firstDate.Split().Select(int.Parse).ToArray();

			DateTime first = new DateTime(firstDateArr[0], firstDateArr[1], firstDateArr[2]);

			var secondDateArr = secondDate.Split().Select(int.Parse).ToArray();

			DateTime second = new DateTime(secondDateArr[0], secondDateArr[1], secondDateArr[2]);

			return Math.Abs((first - second).Days);
		}
	}
}
