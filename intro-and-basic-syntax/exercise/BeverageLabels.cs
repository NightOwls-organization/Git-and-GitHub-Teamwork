//CONFIRMED from PeyoPeev
using System;
					
public class BeverageLabels
{
	public static void Main()
	{
		// read the name of the product -> string
                string foodProductName = Console.ReadLine();
		// read the volume -> int
                int foodProductVolume = int.Parse(Console.ReadLine());
		// read the energy of the product -> int
                int foodProductEnergy = int.Parse(Console.ReadLine());
		// read the sugar ->int
                int foodProductSugar = int.Parse(Console.ReadLine());
                // write on the screen
                System.Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",volume,name,(volume*energy)/100.00,(sugar*volume)/100.00);
	}
}
