//CONFIRMED from DimitarApostolov
using System;

namespace _05_CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiving the name from the console -> string
            string characterName = Console.ReadLine();
	    /* In the next three lines, we recieve health,
	     * healthMax, energy and energyMax as an
             * integer */
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

	    /* We concatenate the health and healthMax
	     * for the health we use the character '|'
	     * and for the remaining health we use '.' */
            string currentHealth = "|" + new string('|', health) + new string('.', healthMax - health) + "|";
           
	    /* We concatenate the energy and energyMax
             * for the health we use the character '|'
             * and for the remaining health we use '.' */
	    string currentEnergy = "|" + new string('|', energy) + new string('.', energyMax - energy) + "|";
	    
	    /* In the next three lines we print
	     * on the console the name and
	     * the concatenatet strings for 
	     * currentHealth and currentEnergy*/
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {currentHealth}");
            Console.WriteLine($"Energy: {currentEnergy}");


        }
    }
}
