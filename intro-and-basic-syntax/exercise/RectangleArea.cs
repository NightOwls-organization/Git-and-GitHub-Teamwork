using System;

class RecArea
{
    static void Main(string[] args)
    {
	//Receiving the width from the console -> float
        float width = float.Parse(Console.ReadLine());
	//Receiving the depth from the console -> float
        float depth = float.Parse(Console.ReadLine());

	/* In the next line we calculate the 
	 * rectangle area with the formula
	 * width multiplied by depth
	 * then we fix the point to the second zero */ 
        Console.WriteLine($"{(width * depth):f2}");
    }
}

