﻿namespace _02._Class_Box
{
	using System;

	public class Program
	{
		public static void Main(string[] args)
		{
			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());

			try
			{
				Box box = new Box(length, width, height);

				Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
				Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
				Console.WriteLine($"Volume - {box.Volume():f2}");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
