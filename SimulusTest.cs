namespace OpenCloseLock_Chest
{

    enum ChestState
    {
        Locked,
        Unlocked,
        Open
    }

    class Program
    {
        static void Main()
        {
            ChestState chest = ChestState.Locked;

            while (true)
            {
                Console.WriteLine($"The chest is {chest.ToString()}. What do you want to do?");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "unlock":
                        if (chest == ChestState.Locked)
                            chest = ChestState.Unlocked;
                        break;
                    case "lock":
                        if (chest == ChestState.Unlocked)
                            chest = ChestState.Locked;
                        break;
                    case "open":
                        if (chest == ChestState.Unlocked)
                            chest = ChestState.Open;
                        break;
                    case "close":
                        if (chest == ChestState.Open)
                            chest = ChestState.Unlocked;
                        break;
                }
            }
        }
    }
}

