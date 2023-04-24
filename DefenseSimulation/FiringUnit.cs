using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseSimulation
{
    public enum FireResult
    {
        Hit,
        Miss
    }

    public class FiringUnit
    {
        private readonly double hitProbability;

        public FiringUnit(double hitProbability)
        {
            this.hitProbability = hitProbability;
        }

        public FireResult Fire()
        {
            if (SimulateHitRoll() <= hitProbability)
                return FireResult.Hit;

            return FireResult.Miss;
        }

        private static double SimulateHitRoll()
        {
            Random random = new Random();
            double hitRoll = random.NextDouble();
            return hitRoll;
        }
    }
}
