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

        public FireResult Fire()
        {
            if (SimulateLaunch() <= hitProbability)
                return FireResult.Hit;

            return FireResult.Miss;
        }

        private static double SimulateLaunch()
        {
            Random random = new Random();
            double hitRoll = random.NextDouble();
            return hitRoll;
        }
    }
}
