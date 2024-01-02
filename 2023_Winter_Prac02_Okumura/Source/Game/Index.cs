using System;
using System.Runtime.CompilerServices;
using Game.Entity.Users;
using Game.Entity.Vehicles;
using Interface.entity.Vehicles;
using Interface.Entity.Characters;

namespace Game {
    public class Index {

        // Set map size.
        public int mapSize = 6; // 6 x 6

        // Generate map 6 x 6
        public string[,] ?map;

        // Generate each submarine.
        public Submarine submarine = new();

        // Generate each character instance.
        public User user = new();
        public Computer computer = new();

        public void GenerateMap() {
            map = new string[mapSize, mapSize];
            // Generate map.
            for (int i = 0; i < map.GetLength(0); i++) {
                for (int j = 0; j < map.GetLength(1); j++) {
                    map[i, j] = "";
                }
            }
        }
        public void ShowMap() {
            // Show map.
            Console.WriteLine("   0  1  2  3  4  5");
            for (int i = 0; i < map.GetLength(0); i++) {
                Console.Write(i + " ");
                for (int j = 0; j < map.GetLength(1); j++) {
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void GenerateSubmarine() {
            // Generate user's submarine.
            user.GenerateSubmarine(mapSize - 1);
            // Generate computer's submarine.
            computer.GenerateSubmarine(mapSize - 1);

            // Place computer's submarine.
            foreach (KeyValuePair<int, Submarine> submarine in computer.submarineMap) {
                map[0, submarine.Key] = "敵";
            }
            // Place user's submarine.
            foreach (KeyValuePair<int, Submarine> submarine in user.submarineMap) {
                map[5, submarine.Key] = "自";
            }

        }

        public void Update() {

            int target;

            // While game is not over.
            while (true) {
                // Show map.
                ShowMap();

                // User's turn.
                // Attack.
                do {
                    Console.WriteLine("User's turn.");
                    target = user.Attack();
                    if (map[0, target] != " ") {
                        try {
                            if (computer.submarineMap[target].hp > 0) {
                                computer.submarineMap[target].Hit();
                            }
                        } catch (KeyNotFoundException) {
                            Console.WriteLine("There is no submarine.");
                            break;
                        }
                        // Check if submarine is destroyed.
                        if (computer.submarineMap[target].hp <= 0) {
                            map[0, target] = " ";
                        }
                        break;
                    } else {
                        Console.WriteLine("There is no submarine.");
                        break;
                    }
                } while (true);
                // Check if game is over.
                if (IsGameOver()) {
                    break;
                }

                // Computer's turn.
                Console.WriteLine("Computer's turn.");
                // Attack.
                do {
                    target = computer.Attack();
                    if (map[5, target] != " ") {
                        try {
                            if (user.submarineMap[target].hp > 0) {
                                user.submarineMap[target].Hit();
                            }
                        } catch (KeyNotFoundException) {
                            Console.WriteLine("There is no submarine.");
                            break;
                        }
                        // Check if submarine is destroyed.
                        if (user.submarineMap[target].hp <= 0) {
                            map[5, target] = " ";
                        }
                        break;
                    }
                } while (true);
                // Check if game is over.
                if (IsGameOver()) {
                    break;
                }
            }
        }

        private bool IsGameOver() {
            bool isUserAlive = false;
            bool isComputerAlive = false;

            // Check if computer's submarine is shown in the map.
            foreach (KeyValuePair<int, Submarine> submarine in computer.submarineMap) {
                if (map[0, submarine.Key] == "敵") {
                    isUserAlive = true;
                }
            }
            // Check if user's submarine is shown in the map.
            foreach (KeyValuePair<int, Submarine> submarine in user.submarineMap) {
                if (map[5, submarine.Key] == "自") {
                    isComputerAlive = true;
                }
            }

            // Check if game is over.
            if (!isUserAlive) {
                Console.WriteLine("Computer won.");
                return true;
            } else if (!isComputerAlive) {
                Console.WriteLine("User won.");
                return true;
            } else {
                return false;
            }
        }

    }
}
