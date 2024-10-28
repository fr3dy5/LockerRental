using System;

public static class ConsoleIO
{
    private static int userChoice; // for menu options
    private static int lockerNumber; // the locker number the user picks
    private static int lockerIndex; // the array index of the locker number

    public static string GetRequiredString(); //prompt user string input
    {
        throw new NotImplementedException();
    }

    public static void DisplayLockerContents(LockerContents, int LockerNumber); // display locker contents
    {
        if (string.IsNullOrEmpty(lockerContents))
        {
            Console.WriteLine($"Locker {lockerNumber} is EMPTY");
        }
        else
        {
            Console.WriteLine($"Locker {lockerNumber} contents: {lockerContents}");
        }
    }

    public static int GetLockerNumber(); // prompt for locker number from user
    {
        while (true)
        {
            Console.Write("Enter locker number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out lockerNumber))
            {
                if (lockerNumber >= 1 && lockerNumber <= 100)
                {
                    lockerIndex = lockerNumber - 1; // adjust for index
                    return lockerNumber;
                }
            }
            
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 100.");
        }
    }

    public static int GetMenuOption(); // display menu and choice prompt
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Locker Rental Menu");
            Console.WriteLine("=============================");
            Console.WriteLine("1. View a locker");
            Console.WriteLine("2. Rent a locker");
            Console.WriteLine("3. End a locker rental");
            Console.WriteLine("4. List all locker contents");
            Console.WriteLine("5. Quit");
            Console.Write("\nEnter your choice (1-5): ");

            if (int.TryParse(Console.ReadLine(), out userChoice))
            {
                if (userChoice >= 1 && userChoice <= 5)
                {
                    return userChoice;
                }
            }

            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        }
    }

    public static void AnyKey(); // display "press any key to continue" message pause app after data display
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
    }

}