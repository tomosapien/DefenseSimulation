using DefenseSimulation;

Radar radar = new ();
IFF identificationFF = new ();
PatriotSystem patriot = new (radar, identificationFF);

int simulateCycles = radar.GetRadarDataCount();

for (int i = 1; i <= simulateCycles; i++)
{
    Console.WriteLine("\n" + DateTime.Now.ToString("HH:mm:ss") + " - Simulate cycle {0}", i);
    patriot.Run();

    Thread.Sleep(1000);
}
