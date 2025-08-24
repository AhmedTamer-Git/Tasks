using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class Car : IMovable , IVehicle
    {
        #region Special for D7
        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }
        #endregion

        public void StartEngine()
        {
            Console.WriteLine("Car engine started."); 
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
   
    }
}
