using System;
					
public class DebitCardNumber
{
	public static void Main()
	{
		int numberOne = int.Parse(Console.ReadLine());
		int numberTwo = int.Parse(Console.ReadLine());
		int numberThree = int.Parse(Console.ReadLine());
		int numberFour = int.Parse(Console.ReadLine());

		System.Console.WriteLine($"{numberOne:D4} {numberTwo:D4} {numberThree:D4} {numberFour:D4}");
	}
}
