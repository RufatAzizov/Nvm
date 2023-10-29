using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStuff.Interfaces;

namespace CarStuff
{
    public class Car : Vehicle, IEngine, IWheel, ITransmission
        {
        #region Fields
        public uint HorsePower { get; set; }
            public uint TankSize { get; set; }
            public uint CurrentOil { get; set; }
            public string FuelType { get; set; }
            public byte DoorCount { get; set; }
            public string VinCode { get; set; }
            public uint WheelThickness { get; set; }
            public string TransmissionKind { get; set; }
        #endregion

        public Car(uint driveTime, uint drivePath, uint horsePower, uint tankSize, uint currentOil, string fuelType, byte doorCount, string vinCode)
        : base(driveTime, drivePath)
        {
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            DoorCount = doorCount;
            VinCode = vinCode;
        }

        public override double AverageSpeed()
            {
                return 0;
            }

            public float RemainOilAmount()
            {
                return 0;
            }

           
        }
}

