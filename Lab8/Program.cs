using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {

        

        static void Main(string[] args)
        {
            string[] names = { "Mr. Meeseeks", "Lord Canti", "Solid Snake", "Cloud Strife", "King Mrgl-Mrgl" };
            string[] origin = { "Meeseeks Box", "Naota Nandaba's Head", "Redacted", "Nibelheim", "Unclear" };
            string[] hobbies = { "Completeing Tasks Before the Pain Drives them insane.", "Starting fires.", "Redacted", "Chocabo Breeding", "Observing the life of a Murloc", };

            Console.WriteLine("Enter a Number From 1-5 to learn more about a subject.");
            string nameNum = Console.ReadLine();
            while (!Regex.IsMatch(nameNum, @"^[12345]$"))
            {
                
                Console.WriteLine("Error: Entered a value either out of Range or wrong format");
                Console.WriteLine("Please enter a number between 1 and 5;");
                nameNum = Console.ReadLine();
            }
            int indexName = int.Parse(nameNum);
            Console.WriteLine($"You chose {names[indexName - 1]}!!!");
            Console.WriteLine("Would you like to learn more?(enter Origin or Hobby");
            string pick1 = Console.ReadLine();
            while(!Regex.IsMatch(pick1, @"^Origin|origin|Hobby|hobby$" ))
            {
               
                Console.WriteLine("Error: Please make sure to only enter one of the two options");
                Console.WriteLine("Please enter either Hobby or Origin");
                pick1 = Console.ReadLine();
            }
            if (pick1 == "Hobby" || pick1 == "hobby")
            {
                Console.WriteLine($"You chose {pick1}, {names[indexName-1]} loves to {hobbies[indexName-1]} ");
            }
            else
            {
                Console.WriteLine($"You chose {pick1}, {names[indexName - 1]} comes from {origin[indexName - 1]}. ");
            }
        }
        
            
        
    }

}