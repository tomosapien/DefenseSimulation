using DefenseSimulation;

Radar radar = new ();
IFF identifyFF = new ();
PatriotSim patriotSim = new (radar, identifyFF);

int simulateCycles = radar.GetRadarDataCount();

for (int i = 1; i <= simulateCycles; i++)
{
    Console.WriteLine("\nSimulate cycle {0}", i);
    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
    patriotSim.Run();

    Thread.Sleep(1000);
}
