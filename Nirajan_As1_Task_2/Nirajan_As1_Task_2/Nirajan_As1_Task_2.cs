namespace basketballGame
{
    class joeSpend
    {
        static void Main()
        {
            // Ask Joe for the number of each type of ticket he bought
            Console.Write("Enter the number of Purple tickets you bought($50 each): ");
            int purpleTickets = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Green tickets you bought ($80 each): ");
            int greenTickets = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Blue tickets you bought ($100 each): ");
            int blueTickets = int.Parse(Console.ReadLine());

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
        }
    }
}

