using System;

namespace Interface.entity.Vehicles {
    public interface ISubmarine {
        int unit { get; set; }
        enum WeakPoints {
            Engine,
            Hull,
            Propeller,
            Rudder,
            Sonar,
            Torpedo
        }

        void GenerateSubmarine();
        void Attack(int target);
    }
}
