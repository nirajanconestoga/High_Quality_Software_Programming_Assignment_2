namespace basketballGame
{
    class JoeSpend
    {
        // Define an enum for ticket types with corresponding prices
        enum TicketType
        {
            Purple = 50,
            Green = 80,
            Blue = 100
        }
        static void Main()
        {
            // Define variables for the tickets
            int purpleTickets= 0, greenTickets=0, blueTickets=0;

            // Ask Joe for the number of each type of ticket he bought
            try
            {
                Console.Write("Enter the number of Purple tickets you bought: ");
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
                Console.Write("Enter the number of Green tickets you bought: ");
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
                Console.Write("Enter the number of Blue tickets you bought: ");
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

            // Calculation of the total number of games joe attended
            int totalGames = purpleTickets + greenTickets + blueTickets;

            // Calculation of the total cost joe spent using the enum for ticket prices
            double totalCost = (purpleTickets * (int)TicketType.Purple) +
                             (greenTickets * (int)TicketType.Green) +
                             (blueTickets * (int)TicketType.Blue);

            // Calculate the average price per game
            double averagePrice;
            if (totalGames > 0)
            {
                averagePrice = totalCost / totalGames;
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

