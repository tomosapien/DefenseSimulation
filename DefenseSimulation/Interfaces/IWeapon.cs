using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseSimulation.Interfaces
{
    public enum FireResult
    {
        Hit,
        Miss
    }

    public interface IWeapon
    {
        public FireResult Fire();
    }
}
