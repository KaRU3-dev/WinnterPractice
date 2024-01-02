using System;

using Interface.entity.Vehicles;

namespace Game.Entity.Vehicles {
    public class Submarine : ISubmarine {
        public int unit { get; set; }
        public double hp { get; set; } = 100.0;
        public enum WeakPoints {
            Engine,
            Hull,
            Propeller,
            Rudder,
            Sonar,
            Torpedo
        }
        public void Hit() {
            // Generate random number.
            Random random = new();
            int hit = random.Next(0, 6);

            // Hit the submarine.
            if (hit == (int)WeakPoints.Engine) {
                Console.WriteLine("Engine was hit.");

                // Reduce hp.
                hp -= 50.0;

            } else if (hit == (int)WeakPoints.Hull) {
                Console.WriteLine("Hull was hit.");

                // Reduce hp.
                hp -= 30.0;

            } else if (hit == (int)WeakPoints.Propeller) {
                Console.WriteLine("Propeller was hit.");

                // Reduce hp.
                hp -= 20.0;

            } else if (hit == (int)WeakPoints.Rudder) {
                Console.WriteLine("Rudder was hit.");

                // Reduce hp.
                hp -= 2.0;

            } else if (hit == (int)WeakPoints.Sonar) {
                Console.WriteLine("Sonar was hit.");

                // Reduce hp.
                hp -= 2.0;

            } else if (hit == (int)WeakPoints.Torpedo) {
                Console.WriteLine("Torpedo was hit.");

                // Reduce hp.
                hp -= 2.0;

            }
        }
    }
}
