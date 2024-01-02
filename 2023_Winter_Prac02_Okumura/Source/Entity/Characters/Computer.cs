using System;
using Game.Entity.Vehicles;
using Interface.Entity.Characters;

namespace Game.Entity.Users {
    public class Computer : ICharacter {
        public string name { get; set; } = "Computer";
        public double hp { get; set; } = 100.0;
        public int unit { get; set; } = 5;

        // Submarine map
        public Dictionary<int, Submarine> submarineMap = new Dictionary<int, Submarine>();

        public void GenerateSubmarine(int mapSize) {
            for (int i = 0; i < unit; i++) {
                // Generate random number.
                Random random = new();
                int index = random.Next(0, mapSize);

                // Generate submarine dictionary.
                Submarine submarine = new();
                if (submarineMap.ContainsKey(index)) {
                    i--;
                    continue;
                } else {
                    submarineMap.Add(index, submarine);
                }
            }
        }
        public int Attack() {
            // Generate random number.
            Random random = new();
            int targetSubmarine = random.Next(0, 5);

            return targetSubmarine;
        }
    }
}
