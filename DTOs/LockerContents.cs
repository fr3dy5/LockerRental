public static class LockerContents
{
    private static string description;
    private static string renterName;

    public static string Description // contents of the locker
    {
        get { return description; }
        set 
        { 
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("You must provide an item description.");
            }
            else
            {
                description = value;
            }
        }
    }

    public static string RenterName //renter name
    {
        get { return renterName; }
        set { renterName = value; }
    }

}