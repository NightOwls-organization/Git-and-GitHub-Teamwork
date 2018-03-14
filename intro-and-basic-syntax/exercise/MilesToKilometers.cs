//CONFIRMED from SvetlanaKaraasenova
using System;
					
public class MilesToKilometers
{
	public static void Main()
	{
        //Receiving miles, that need to be converted
		decimal miles = decimal.Parse(Console.ReadLine());

        //Printing the calculated conversion - miles->kilometres
		System.Console.WriteLine("{0:0.00}",miles*1.60934m);
	}
}