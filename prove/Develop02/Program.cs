using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // Add a sample entry
        Entry entry = new Entry();
        entry.Prompt = "What was the highlight of my week?";
        entry.EntryTest = "I had a great conversation with a friend I hadn't seen in a while. We caught up on each other's lives and shared some laughs. It was a much-needed boost to my mood.";
        entry.Date = "2023-09-28";
        journal.AddEntry(entry);

        while (true)
        {
            // Display the journal menu
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Show Random Prompt");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option: ");

            // Get the user's selection
            int option = Convert.ToInt32(Console.ReadLine());

            // Handle the user's selection
            switch (option)
            {
                case 1:
                    // Show a random prompt
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine("Journal Entry Prompt: " + randomPrompt);
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    Console.Write("Date: ");
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    
                    Console.WriteLine("Select your mood:");
                    Console.WriteLine("1. Happy");
                    Console.WriteLine("2. Sad");
                    Console.WriteLine("3. Neutral");
                    Console.WriteLine("4. Angry");
                    Console.WriteLine("5. Surprised");

                    Console.Write("Enter the number of your mood: ");
                    int moodChoice = int.Parse(Console.ReadLine());

                    Journal.Mood mood = (Journal.Mood)(moodChoice - 1); // Convert the choice to the enum value


                    Entry newEntry = new Entry(randomPrompt, response,  date, mood.ToString());
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    // Display the journal
                    journal.DisplayAll();
                    break;
                case 3:
                    // Save the journal to a file
                    string fileToSave = Console.ReadLine();
                    journal.SaveToFile(fileToSave);
                    break;
                case 4:
                    // Load the journal from a file
                    string fileToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileToLoad);
                    break;
                case 5:
                    // Exit the program
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}