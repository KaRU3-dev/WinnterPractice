// Practice 03: Number guess game
using System;

namespace Ignition {
    public class Program {
        public static void Main(string[] args) {
            // Init classes
            GameEngine.Game game = new(5);

            // Game loop
            game.GameLoop();
        }
    }
}
