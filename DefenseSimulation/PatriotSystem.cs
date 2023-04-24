using DefenseSimulation.Interfaces;

namespace DefenseSimulation
{
    public class PatriotSystem
    {
        private readonly Radar radar;
        private readonly IFF identificationFF;
        private readonly IWeapon missileLauncher;

        public PatriotSystem(Radar radar, IFF identifyFF)
        {
            this.radar = radar;
            this.identificationFF = identifyFF;
            this.missileLauncher = new MissileLauncher(0.8);
        }

        public void Run()
        {
            // Get information from radar
            var radarScan = radar.GetRadarScan();

            // Let the IFF identify the entity
            var flyingObject = identificationFF.Identify(radarScan);
            
            // Depending on identity, decide course of action
            switch(flyingObject)
            {
                case ObjectIdentity.Unidentified:
                    Console.WriteLine("Unidentified flying object detected!");
                    break;
                case ObjectIdentity.Friend:
                    Console.WriteLine("Friendly aircraft detected, no further action.");
                    break;
                case ObjectIdentity.Foe:
                    Console.WriteLine("Hostile aircraft detected!! Attempting to neutralize..");
                    NeutralizeAircraft();
                    break;
                default:
                    break;
            }
        }

        private void NeutralizeAircraft()
        {
            var fireResult = missileLauncher.Fire();
            if (fireResult == FireResult.Hit)
            {
                Console.WriteLine("Hostile has been neutralized.");
            }
            else
            {
                Console.WriteLine("MISSED! Hostile is still intact.");
            }
            return;
        }
    }
}
