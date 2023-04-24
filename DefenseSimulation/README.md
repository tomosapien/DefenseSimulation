# DefenseSimulation

This project simulates a Patriot air defense system, that consists of a Radar, IFF and Firing unit.

The radar is simulated by reading a .csv file. At this moment the file is hard-coded and there be please be sure to name the file
"Radar-output.csv" and that it is located in the same folder as "DefenseSystem.exe".
"DefenseSystem.exe" is located in bin/Release/net6.0-windows/* and can be executed in order to run the simulation.

The IFF (Identification Friend or Foe) system will determine from the radar data if the flying object is friend or foe or remains unidentified.

If a foe is identified, the Patriot system will utilize the firing unit to launch a missile and hopefully eliminate the hostile.
