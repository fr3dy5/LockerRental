public static class LockerManager
{

    private LockerContents[]_lockers; //array for locker content data
    {
        string[] lockers = new string[100];
    }

    public static void ListContents(); //display contents of non-null elements
    {
        // List all
        {
            for (int i = 0; i < lockers.Length; i++)
            {
                if (lockers[i] != null)
                {
                    Console.WriteLine($"Locker {i + 1}: {lockers[i]}");
                }
            }
        }
    }    

    public static void ViewLocker(int number); //to display contents if locker isnt null
    {
        // View Locker

        if (lockers[lockerIndex] == null)
        {
            Console.WriteLine($"Locker {lockerNumber} is EMPTY");
        }
        else
        {
            Console.WriteLine($"Locker {lockerNumber} contents: {lockers[lockerIndex]}");
        }
    }

    public static void RentLocker(int number); //check if locker is available(null) if available makes a lockercontents data transfer object and uses consoleio to populate it
    { // Rent Locker
        {// is the locker already rented?

            if (lockers[lockerIndex] != null)
            {
                Console.WriteLine($"Sorry, but locker {lockerNumber} has already been rented!");
            }
            else
            {
                do
                {
                    Console.Write("Enter the item you want to store in the locker: ");
                    string item = Console.ReadLine();

                    if (!string.IsNullOrEmpty(item))
                    {
                        lockers[lockerIndex] = item;
                        Console.WriteLine($"Locker {lockerNumber} has been rented for {item} storage.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You must provide an item description.");
                    }
                } while (true);
            }
        }
    }

    public static void EndRental(int number); //if not null print message and set element to null
    {
        // End locker rental
        {
            if (lockers[lockerIndex] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is not currently rented.");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} rental has ended, please take your {lockers[lockerIndex]}.");
                lockers[lockerIndex] = null;
            }
        }  
    }
}