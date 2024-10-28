using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        // ListingActivity listingActivity = new ListingActivity("Listing", "List things you are grateful for...", duration);
        // ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "Reflect on your strengths...", duration);

        // Run activities
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Quit");
            Console.Write("Input your number of choice here:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("How long will you like your session to last (in seconds): ");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    BreathingActivity activity = new BreathingActivity("My Breathing Session", "Relax and breathe deeply.", duration);
                    activity.Run(); // Start the activity
                    break;
                case 2:
                    Console.Write("How long will you like your session to last (in seconds): ");
                    duration = Convert.ToInt32(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity("Listing", "List things you are grateful for...", duration);
                    listingActivity.Run(); // Start the activity
                    break;
                case 3:
                    Console.Write("How long will you like your session to last (in seconds): ");
                    duration = Convert.ToInt32(Console.ReadLine());
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "Reflect on your strengths...", duration);
                    reflectingActivity.Run(); // Start the activity
                    break;
                case 4:
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }

    }
}

