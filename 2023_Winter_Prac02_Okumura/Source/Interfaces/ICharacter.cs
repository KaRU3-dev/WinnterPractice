using System;

namespace Interface.Entity.Characters {
    public interface ICharacter {
        string name { get; set; }
        double hp { get; set; }
        int unit { get; set; }

        // Submarine map interface (index, name, hp, alive)
        struct SubmarineMap {
            int index;
            string name;
            double hp;
            bool alive;
        }

        void GenerateSubmarine(int mapSize);
        int Attack();
    }
}
