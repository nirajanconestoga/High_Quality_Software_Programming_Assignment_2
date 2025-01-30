namespace BasketballGame
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

        // Method to handle user input for tickets
        static int GetTicketInput(string ticketType)
        {
            int tickets = 0;
            Console.Write($"Enter the number of {ticketType} tickets you bought: ");
            try
            {
                tickets = int.Parse(Console.ReadLine());
                if (tickets < 0)
                {
                    Console.WriteLine("Invalid ticket number.");
                    return -1; // Indicate invalid input
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return -1; // Indicate invalid input
            }
            return tickets;
        }

        static void Main()
        {
            // Define variables for the tickets
            int purpleTickets = 0, greenTickets = 0, blueTickets = 0;

            // Get user input for each type of ticket
            purpleTickets = GetTicketInput("Purple");
            if (purpleTickets == -1) return;

            greenTickets = GetTicketInput("Green");
            if (greenTickets == -1) return;

            blueTickets = GetTicketInput("Blue");
            if (blueTickets == -1) return;

            // Calculation of the total number of games Joe attended
            int totalGames = purpleTickets + greenTickets + blueTickets;

            // Calculation of the total cost Joe spent using the enum for ticket prices
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
