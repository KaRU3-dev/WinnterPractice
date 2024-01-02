using System;

namespace GameEngine.Generator {
    public class ProblemGenerator {
        Random random;

        // Constructor
        public ProblemGenerator(Random random) {
            this.random = random;
        }

        // Generator
        public int RandomNumber(int min, int max) {
            int randomNumber = random.Next(min, max);

            return randomNumber;
        }
    }
}
