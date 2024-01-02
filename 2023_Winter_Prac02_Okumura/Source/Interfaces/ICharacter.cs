using System;

namespace Interface.Entity.Characters {
    public interface ICharacter {
        string name { get; set; }
        double hp { get; set; }
        int unit { get; set; }

        void GenerateSubmarine();
        void Attack(int target);
    }
}
