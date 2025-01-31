namespace BasketballGame
{
    class JoeSpend
    {
        // enum for ticket types with corresponding prices
        enum ticketType
        {
            Purple = 50,
            Green = 80,
            Blue = 100
        }

        // Method to handle user input for tickets
        static int getTicketInput(string ticketType)
        {
            int tickets = 0;
            Console.WriteLine($"Enter the number of {ticketType} tickets you bought: ");
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
                return -1;
            }
            return tickets;
        }

        static void Main()
        {
            // Variables for the tickets
            int purpleTickets = 0, greenTickets = 0, blueTickets = 0;

            // User input for each type of ticket
            purpleTickets = getTicketInput("Purple");
            if (purpleTickets == -1) return;

            greenTickets = getTicketInput("Green");
            if (greenTickets == -1) return;

            blueTickets = getTicketInput("Blue");
            if (blueTickets == -1) return;

            // Calculation of the total number of games Joe attended
            int totalGames = purpleTickets + greenTickets + blueTickets;

            // Calculation of the total cost Joe spent using the enum for ticket prices
            double totalCost = (purpleTickets * (int)ticketType.Purple) +
                             (greenTickets * (int)ticketType.Green) +
                             (blueTickets * (int)ticketType.Blue);

            // Calculation of the average price per game
            double averagePrice;
            if (totalGames > 0)
            {
                averagePrice = totalCost / totalGames;
            }
            else
            {
                averagePrice = 0;
            }

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
