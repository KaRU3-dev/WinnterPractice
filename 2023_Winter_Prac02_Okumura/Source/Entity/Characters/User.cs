using System;
using Game.Entity.Vehicles;
using Interface.Entity.Characters;

namespace Game.Entity.Users {
    public class User : ICharacter {
        public string name { get; set; } = "User";
        public double hp { get; set; } = 100.0;
        public int unit { get; set; } = 5;

        // Submarine map
        public Dictionary<int, Submarine> submarineMap = new Dictionary<int, Submarine>();

        public void GenerateSubmarine(int mapSize) {
            for (int i = 0; i < unit; i++) {
                // Request where to place the submarine.
                Console.Write($"Where do you want to place your submarine? (0 to {mapSize}): ");
                int index = Convert.ToInt32(Console.ReadLine());
                // Generate submarine dictionary.
                Submarine submarine = new();
                if (submarineMap.ContainsKey(index)) {
                    Console.WriteLine("There is already a submarine.");
                    i--;
                    continue;
                }else if (mapSize < index || index < 0) {
                    Console.WriteLine("You can't place a submarine there.");
                    i--;
                    continue;
                } else {
                    submarineMap.Add(index, submarine);
                }
            }
        }
        public int Attack() {
            // Request target submarine.
            Console.Write("Which submarine do you want to attack? (0 to 5): ");
            int targetSubmarine = Convert.ToInt32(Console.ReadLine());

            return targetSubmarine;
        }
    }
}
