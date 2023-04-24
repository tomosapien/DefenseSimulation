using DefenseSimulation.Interfaces;

namespace DefenseSimulation
{
    public class MissileLauncher : IWeapon
    {
        private readonly double hitProbability;

        public MissileLauncher(double hitProbability)
        {
            this.hitProbability = hitProbability;
        }

        /// <summary>
        /// Simulates the firing of a missile. It checks if the Hit roll is smaller than or equal to the hit probability. 
        /// If it is, it will return Hit. Otherwise it returns Miss
        /// </summary>
        /// <returns>Hit or Miss</returns>
        public FireResult Fire()
        {
            if (SimulateLaunch() <= hitProbability)
                return FireResult.Hit;

            return FireResult.Miss;
        }

        /// <summary>
        /// Generate a number between 0.0 and 1.0, uniformly distributed
        /// </summary>
        /// <returns>A number between 0.0 and 1.0</returns>
        private static double SimulateLaunch()
        {
            Random random = new Random();
            double hitRoll = random.NextDouble();
            return hitRoll;
        }
    }
}
