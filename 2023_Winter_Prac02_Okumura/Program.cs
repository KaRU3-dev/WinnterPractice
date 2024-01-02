// Practice 02: Submarine game
using System;

using Game;

namespace Core {
    public class Program {
        public static void Main(string[] args) {
            // Generate core instance.
            Game.Index index = new();

            // Generate map.
            index.GenerateMap();

            // Generate submarine.
            index.GenerateSubmarine();

            // Show map.
            index.ShowMap();

            // Start game.
            index.Update();
        }
    }
}
