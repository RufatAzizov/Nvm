using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStuff
{
    public abstract class Vehicle
    {
        public uint DriveTime { get; set; }
        public uint DrivePath { get; set; }

        public Vehicle(uint driveTime, uint drivePath)
        {
            DriveTime = driveTime;
            DrivePath = drivePath;
        }

        public abstract double AverageSpeed();
    }
}
