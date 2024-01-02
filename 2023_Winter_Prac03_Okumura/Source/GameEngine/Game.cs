using System;

using GameEngine.Request;
using GameEngine.Generator;
using GameEngine.Support;

namespace GameEngine {
    public class Game {
        // Set game state
        public enum State {
            Playing,
            Finish
        }
        public State state;

        // Variables
        Random random = new();
        int totalProblems = 0;
        int correctAmount = 0;
        int problemNumber = 0;
        int guessCounts = 0;
        double level = 0;

        // Constructor
        public Game(int totalProblems) {
            // Init variables
            this.totalProblems = totalProblems;
            correctAmount = 0;
            problemNumber = 0;
            guessCounts = 0;
            level = 0;

            // Set game state
            state = State.Playing;
        }

        // Game loop
        public void GameLoop() {
            // Init classes
            Requests requests = new();
            ProblemGenerator problemGenerator = new(random);

            // Game loop
            while (state == State.Playing) {

                // Check guess
                Checker checker = new();

                do {
                    // Generate problem
                    int problem = problemGenerator.RandomNumber(1, 30);

                    // Check if guess count is 5
                    if (guessCounts == 5) {
                        Console.WriteLine($"You have reached the maximum number of guesses ({guessCounts})!");
                        guessCounts = 0;
                        break;
                    }

                    // Get guess
                    int guess = requests.SetGuess();

                    // Check guess
                    bool correct = checker.Teacher(guess, problem);

                    // Increment correct amount
                    if (correct) {
                        level += 100 - (guessCounts * 10);
                        guessCounts = 0;
                        break;
                    } else {
                        guessCounts++;
                    }
                } while (problemNumber < 5);


                // Increment problem number
                problemNumber++;

                // Check if game is finished
                if (problemNumber == totalProblems) {
                    state = State.Finish;
                }
            }

            // Print results
            Console.WriteLine($"Your level is {level}!");
        }
    }
}
