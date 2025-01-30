namespace basketballGame
{
    class joeSpend
    {
        static void Main()
        {
            int purpleTickets = 0, greenTickets=0, blueTickets=0;
            // Ask Joe for the number of each type of ticket he bought
            try
            {
                Console.Write("Enter the number of Purple tickets you bought($50 each): ");
                purpleTickets = int.Parse(Console.ReadLine());
                if (purpleTickets < 0)
                {
                    Console.WriteLine("Invalid ticket number");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            try
            {
                Console.Write("Enter the number of Purple tickets you bought($50 each): ");
                greenTickets = int.Parse(Console.ReadLine());
                if (greenTickets < 0)
                {
                    Console.WriteLine("Invalid ticket number");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            try
            {
                Console.Write("Enter the number of Purple tickets you bought($50 each): ");
                blueTickets = int.Parse(Console.ReadLine());
                if (blueTickets < 0)
                {
                    Console.WriteLine("Invalid ticket number");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Calculation of the total cost joe spent
            int totalCost = (purpleTickets * 50) + (greenTickets * 80) + (blueTickets * 100);

            // Calculation of the total number of games joe attended
            int totalGames = purpleTickets + greenTickets + blueTickets;

            // Calculate the average price per game
            double averagePrice;

            if (totalGames > 0)
            {
                averagePrice = (double)totalCost / totalGames;
            }
            else
            {
                averagePrice = 0;
            }

            // Display the results
            Console.WriteLine($"Total number of Purple tickets: {purpleTickets}");
            Console.WriteLine($"Total number of Green tickets: {greenTickets}");
            Console.WriteLine($"Total number of Blue tickets: {blueTickets}");
            Console.WriteLine($"Total amount spent: ${totalCost}");
            Console.WriteLine($"Total number of games attended: {totalGames}");
            Console.WriteLine($"Average price per game: ${averagePrice:F2}");
            Console.ReadLine();
        }
    }
}

