//CONFIRMED from <irenkaaa>
using System;
					
public class DebitCardNumber
{
	public static void Main()
	{
        // In the next four lines, we enter INTEGERES from the console
        int oneNumber = int.Parse(Console.ReadLine());
		int twoNumber = int.Parse(Console.ReadLine());
		int threeNumber = int.Parse(Console.ReadLine());
		int fourNumber = int.Parse(Console.ReadLine());

        //After that we print the integers in one line and formatting them with "D4" in 4-digit debit card format
        System.Console.WriteLine($"{oneNumber:D4} {twoNumber:D4} {threeNumber:D4} {fourNumber:D4}");
	}
}
