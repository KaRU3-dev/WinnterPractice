using System;

namespace GameEngine.Support {
    public class Checker {
        public bool Teacher(int guess, int answer) {
            if (guess > answer) {
                Console.WriteLine("Too high!");
                return false;
            } else if (guess < answer) {
                Console.WriteLine("Too low!");
                return false;
            } else {
                Console.WriteLine("Correct!");
                return true;
            }
        }
    }
}
