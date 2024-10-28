using LockerRental.Actions;

namespace LockerRental.Workflows
{
    public static class App
    {
        public static void Run()
        {
            LockerManager _lockerManager = new LockerManager();

            while (true)
            {
                int choice = ConsoleIO.GetMenuOption();

                if(choice == 5)
                {
                    return;
                }
                else if(choice == 4)
                {
                    _lockerManager.ListContents();
                }
                else
                {
                    int lockerNumber = ConsoleIO.GetLockerNumber();

                    if(choice == 1)
                    {
                        _lockerManager.ViewLocker(lockerNumber);
                    }
                    else if(choice == 2)
                    {
                        _lockerManager.RentLocker(lockerNumber);
                    }
                    else
                    {
                        _lockerManager.EndRental(lockerNumber);
                    }
                }
                ConsoleIO.AnyKey();
            }
        }
    }
}