using System;

namespace CardGame
{
    public class CPUPlayer : IPlayer
    {
        private Random random;

        public CPUPlayer()
        {
            random = new Random();
        }

        public int Guess(int[] cards)
        {
            return cards[random.Next(cards.Length)];
        }
    }
}
