using System;

namespace CardGame
{
    public class Game
    {
        private IPlayer player1;
        private IPlayer player2;

        public Game(IPlayer player1, IPlayer player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void Play()
        {
            int[] player1Cards = GenerateRandomCards();
            int[] player2Cards = GenerateRandomCards();

            int player1CorrectCount = 0;
            int player2CorrectCount = 0;

            while (player1CorrectCount < 3 && player2CorrectCount < 3)
            {
                Console.WriteLine("Player 1's turn:");
                int player1Guess = player1.Guess(player1Cards);
                Console.WriteLine($"Player 1 guessed: {player1Guess}");

                Console.WriteLine("Player 2's turn:");
                int player2Guess = player2.Guess(player2Cards);
                Console.WriteLine($"Player 2 guessed: {player2Guess}");

                if (player1Guess == player2Cards[0] || player1Guess == player2Cards[1] || player1Guess == player2Cards[2])
                {
                    Console.WriteLine("Player 1: Hit!");
                    player1CorrectCount++;
                }
                else
                {
                    Console.WriteLine("Player 1: Can't comparison.");
                }

                if (player2Guess == player1Cards[0] || player2Guess == player1Cards[1] || player2Guess == player1Cards[2])
                {
                    Console.WriteLine("Player 2: Hit!");
                    player2CorrectCount++;
                }
                else
                {
                    Console.WriteLine("Player 2: Can't comparison.");
                }

                Console.WriteLine();
            }

            if (player1CorrectCount > player2CorrectCount)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (player1CorrectCount < player2CorrectCount)
            {
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }

        private int[] GenerateRandomCards()
        {
            Random random = new Random();
            int[] cards = new int[3];

            for (int i = 0; i < 3; i++)
            {
                cards[i] = random.Next(10);
            }

            return cards;
        }
    }
}
