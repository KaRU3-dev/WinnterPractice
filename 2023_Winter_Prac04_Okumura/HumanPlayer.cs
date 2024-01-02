using System;

namespace CardGame
{
    public class HumanPlayer : IPlayer
    {
        public int Guess(int[] cards)
        {
            int guess;
            do
            {
                Console.Write("Enter your guess (0-9): ");
            } while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 9);

            return guess;
        }
    }
}
