using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Interfaces
{
    internal interface ICars : IVehicle
    {
        void Accelerate();

        void Drive();

        void Stop();

        void TootHorn();
    }
}
