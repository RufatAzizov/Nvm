using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStuff
{
    public class Plane : Vehicle
    {
        public double WingLength { get; set; }

        public Plane(uint driveTime, uint drivePath, double wingLength)
        : base(driveTime, drivePath)
        {
            WingLength = wingLength;
        }

        public override double AverageSpeed()
        {
            return 0;
        }
    }
}
