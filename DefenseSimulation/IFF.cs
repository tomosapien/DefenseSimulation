using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseSimulation
{
    public enum ObjectIdentity
    {
        Unidentified,
        Friend,
        Foe
    }

    public class IFF
    {
        public IFF() { }

        public ObjectIdentity Identify(List<int> radarValues)
        {
            int evenValues = 0;
            foreach (int value in radarValues)
            {
                if (value % 2 == 0)
                    evenValues++;
            }

            if (evenValues > radarValues.Count / 2)
                return ObjectIdentity.Friend;

            if (evenValues < radarValues.Count / 2)
                return ObjectIdentity.Foe;

            return ObjectIdentity.Unidentified;
        }
    }
}
