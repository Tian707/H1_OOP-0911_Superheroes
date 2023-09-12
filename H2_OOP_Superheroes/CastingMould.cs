using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_Superheroes
{
    public class CastingMould
    {
        // Field
        private int _type;
        private string _color;
        private bool _withWIFI;
        private string _chipType;
        private bool _withBattery;
        private byte _batteryCapacity;
        private bool _withSoapContainer;
        private int _numberOfWheels;
        /// <summary>
        /// default constructer, initialize all attributes
        /// </summary>
        private CastingMould()
        {
            _type = 0;
            _color = "White";
            _withWIFI = false;
            _chipType = "default";
            _withBattery = false;
            _batteryCapacity = 0;
            _withSoapContainer = false;
            _numberOfWheels = 0;
        }

        /// <summary>
        /// Basic moulds with type option<br/>
        /// 0 for small, 1 for large
        /// </summary>
        /// <param name="type"></param>
        private CastingMould(int type) : this()
        {
            _type = type;
        }

        /// <summary>
        /// Add chip option, default for small robots<br/>
        /// "RX54667" for Window robots, "QT8339" for Tier robots
        /// </summary>
        /// <param name="size"></param>
        /// <param name="chipType"></param>
        private CastingMould(int type, string chipType) : this(type)
        {
            _chipType = chipType;
        }

        /// <summary>
        /// All robots can have color, default color is set to White. 
        /// A basic robot is created here.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="chipType"></param>
        /// <param name="color"></param>
        private CastingMould(int type, string chipType, string color) : this(type, chipType)
        {
            _color = "White";
        }

        /// <summary>
        /// Soap Container is only build in small robots and window robots
        /// </summary>
        /// <param name="type"></param>
        /// <param name="chipType"></param>
        /// <param name="color"></param>
        /// <param name="withSoapContainer"></param>
        public CastingMould(int type, string chipType, string color, bool withSoapContainer) : this(type, chipType, color)
        {
            // Type 0 small robots have Soap Container
            // Window robots with chipType "RX54667" also have Soap Container
            if (type == 0 || chipType == "RX54667")
            {
                _color = color;
                _withSoapContainer = withSoapContainer;
            }
            // Tier robots don't have SP
            else
            {
                throw new NotImplementedException("Tier robots cannot be equipped with a soap containner.");
            }
        }
        /// <summary>
        /// Option Wheels for Window robots
        /// </summary>
        /// <param name="type"></param>
        /// <param name="chipType"></param>
        /// <param name="color"></param>
        /// <param name="withSoapContainer"></param>
        /// <param name="numberOfWheels"></param>
        /// <exception cref="NotImplementedException"></exception>
        public CastingMould(int type, string chipType, string color, bool withSoapContainer, byte numberOfWheels) : this(type, chipType, color, withSoapContainer)
        {
            // Window robots with chipType "RX54667" and a Soap Container
            // have option for Wheels
            if (type == 1 && chipType == "RX54667")
            {
                _numberOfWheels = numberOfWheels;
            }
            // Wheels are only for Type 1 Large robots
            else
            {
                throw new NotImplementedException("Wrong type to add wheels.");
            }
        }

        /// <summary>
        /// Add Wheels option for Tier robots
        /// </summary>
        /// <param name="type"></param>
        /// <param name="chipType"></param>
        /// <param name="color"></param>
        /// <param name="numberOfWheels"></param>
        private CastingMould(int type, string chipType, string color, byte numberOfWheels) : this(type, chipType, color)
        {
            _color = color;
            _numberOfWheels |= numberOfWheels;
        }

        /// <summary>
        /// Add WIFI option for Tier robots
        /// </summary>
        /// <param name="type"></param>
        /// <param name="chipType"></param>
        /// <param name="color"></param>
        /// <param name="numberOfWheels"></param>
        /// <param name="withWIFI"></param>
        private CastingMould(int type, string chipType, string color, byte numberOfWheels, bool withWIFI) : this(type, chipType, color, numberOfWheels)
        {
            _withWIFI = withWIFI;
        }

        /// <summary>
        /// Only White Tier robots can have battery
        /// </summary>
        /// <param name="type"></param>
        /// <param name="chipType"></param>
        /// <param name="color"></param>
        /// <param name="numberOfWheels"></param>
        /// <param name="withWIFI"></param>
        /// <param name="batteryCapacity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public CastingMould(int type, string chipType, string color, byte numberOfWheels, bool withWIFI, byte batteryCapacity) : this(type, chipType, color, numberOfWheels, withWIFI)
        {
            if (type == 1 && chipType == "QT8339" && color == "White")
            {
                // White Tier robots can have battery
                _batteryCapacity = batteryCapacity;
            }

            else
            {
                throw new NotImplementedException($"Only Tier robots with default color({color}) can be equipped with battery.");
            }
        }
    }
}
