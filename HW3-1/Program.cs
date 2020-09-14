using System;

public class Exercise1
{

	public static void Main(string[] Strings)
	{
		Console.Write("Input a degree in Fahrenheit: ");

		Double input = Convert.ToDouble(Console.ReadLine());


		double fahrenheit = input;

		double celsius = ((5 * (fahrenheit - 32.0)) / 9.0);
		Console.WriteLine(fahrenheit + " degree Fahrenheit is equal to " + celsius + " in Celsius");
	}
}
