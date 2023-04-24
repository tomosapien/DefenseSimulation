using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseSimulation
{
    public class Radar
    {
        private readonly Queue<List<int>> radarData = new Queue<List<int>>();

        public Radar() { 
            LoadRadarData();
        }

        private void LoadRadarData()
        {
            radarData.Clear();

            using (StreamReader sr = new StreamReader("Radar-output.csv"))
            {
                string currentLine;
                while((currentLine = sr.ReadLine()) != null) {
                    radarData.Enqueue(
                        currentLine.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(m => { return Convert.ToInt32(m, 2); })
                        .ToList());                
                }
            }
        }

        public List<int> GetRadarScan()
        {
            return radarData.Dequeue();
        }

        public int GetRadarDataCount()
        {
            return radarData.Count;
        }
    }
}
