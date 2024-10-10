using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Reference object
        Reference reference = new Reference("John", 3, 16);

        // Create a new Scripture object
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Hide words until the scripture is completely hidden
        while (true)
        {
            scripture.HideRandomWords(1);
            Console.WriteLine(scripture.GetDisplayText());

            // Wait for user input or automatically close if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("The scripture is now completely hidden. Goodbye!");
                break;
            }
            else
            {
                Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    break;
                }
            }
        }
    }
}