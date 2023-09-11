using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_RemoteControlledCars.Model
{
    public class RemoteControlledCar
    {
        private int _distance = 0;
        private byte _range = 20;
        private Color _color;
        private bool _isDriving = false;
        public Battery _battery;
        private Display _display;

        public int Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public byte Range
        {
            get { return _range; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        
        
        /// <summary>
        /// A constructor that automatically creates and initializes<br/>
        /// an instance of the Battery and the Display class when <br/>
        /// a RemoteControlledCar object is created. 
        /// </summary>
        public RemoteControlledCar()
        {
            _battery = new Battery();
            _display = new Display();
        }

        public (int, byte) Drive()
        {
            // Start driving
            _isDriving = true; 

            while (_battery.BatteryLeft > 0 && _isDriving)
            {
                Distance += Range;
                _battery.BatteryLeft--;

                // Add a delay of 100 milliseconds to control driving process
                System.Threading.Thread.Sleep(100);

            }
            return (Distance, _battery.BatteryLeft);
        }
        public void Breaking()
        {
            //Stop driving
            _isDriving = false;
        }

        public (bool, int, byte) ResetCar()
        {
            return (_isDriving = false, _distance = 0, _battery.BatteryLeft = 100);
        }
    }
}
