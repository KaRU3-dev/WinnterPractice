using System;

namespace GameEngine.Request {
    public class Requests {
        public int SetTotalProblems() {
            Console.Write("Enter the total number of problems: ");
            int totalProblems = int.Parse(Console.ReadLine());

            return totalProblems;
        }

        public int SetGuess() {
            Console.Write("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());

            return guess;
        }
    }
}
