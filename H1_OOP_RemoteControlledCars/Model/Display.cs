using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_RemoteControlledCars.Model
{
    public class Display
    {
        private int _distance;
        private byte _batteryLeft = 100;

        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
        public byte BatteryLeft
        {
            get { return _batteryLeft; }
            set { _batteryLeft = value; }
        }

    }
}
