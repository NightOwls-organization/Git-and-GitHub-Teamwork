using System;


class RecArea
{
    static void Main(string[] args)
    {
        float width = float.Parse(Console.ReadLine());
        float depth = float.Parse(Console.ReadLine());

        Console.WriteLine($"{(width * depth):f2}");
    }
}

