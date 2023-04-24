namespace DefenseSimulation
{
    public class PatriotSim
    {
        private Radar radar;
        private IFF identifyFF;
        private FiringUnit firingUnit;

        public PatriotSim(Radar radar, IFF identifyFF)
        {
            this.radar = radar;
            this.identifyFF = identifyFF;
            this.firingUnit = new FiringUnit(0.8);
        }

        public void Run()
        {
            // get information from radar
            var radarScan = radar.GetRadarScan();

            // let the IFF identify the entity
            var flyingObject = identifyFF.Identify(radarScan);

            switch(flyingObject)
            {
                case ObjectIdentity.Unidentified:
                    Console.WriteLine("Unidentified flying object detected!");
                    break;
                case ObjectIdentity.Friend:
                    Console.WriteLine("Friendly aircraft detected, no further action.");
                    break;
                case ObjectIdentity.Foe:
                    Console.WriteLine("Hostile aircraft detected! Taking defensive measures");
                    var fireResult = firingUnit.Fire();
                    Console.WriteLine("Opened fire on hostile.. {0} !", fireResult);
                    break;
                default:
                    break;
            }
        }

        public int GetRadarDataCount()
        {
            return radar.GetRadarDataCount();
        }
    }
}
