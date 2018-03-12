using System;
					
public class BeverageLabels
{
	public static void Main()
	{
		// read the name of the product -> string
                string name = Console.ReadLine();
		// read the volume -> int
                int volume = int.Parse(Console.ReadLine());
		// read the energy of the product -> int
                int energy = int.Parse(Console.ReadLine());
		// read the sugar ->int
                int sugar = int.Parse(Console.ReadLine());
                // write on the screen
                System.Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",volume,name,(volume*energy)/100.00,(sugar*volume)/100.00);
	}
}
