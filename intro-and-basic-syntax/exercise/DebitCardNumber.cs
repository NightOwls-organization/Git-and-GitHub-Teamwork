//CONFIRMED from <irenkaaa>
using System;
					
public class DebitCardNumber
{
	public static void Main()
	{
		int oneNumber = int.Parse(Console.ReadLine());
		int twoNumber = int.Parse(Console.ReadLine());
		int threeNumber = int.Parse(Console.ReadLine());
		int fourNumber = int.Parse(Console.ReadLine());

		System.Console.WriteLine($"{oneNumber:D4} {twoNumber:D4} {threeNumber:D4} {fourNumber:D4}");
	}
}
