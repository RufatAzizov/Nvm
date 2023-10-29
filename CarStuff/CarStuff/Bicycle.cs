using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStuff.Interfaces;

namespace CarStuff
{
    public class Bicycle : Vehicle, IWheel
    {
        public uint WheelThickness { get; set; }
        public string PedalKind { get; set; }

        public Bicycle(uint driveTime, uint drivePath, uint wheelThickness, string pedalKind)
        : base(driveTime, drivePath)
        {
            WheelThickness = wheelThickness;
            PedalKind = pedalKind;
        }

        public override double AverageSpeed()
        {
            return 0;
        }
    }
}
