using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_RemoteControlledCars.Model
{
    public class Battery
    {
        private byte _batteryLeft = 100;

        public byte BatteryLeft
        {
            get { return _batteryLeft; }
            set { _batteryLeft = value; }
        }
    }
}
