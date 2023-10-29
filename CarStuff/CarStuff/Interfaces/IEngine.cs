using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStuff.Interfaces
{
    public interface IEngine
    {
        uint HorsePower { get; set; }
        uint TankSize { get; set; }
        uint CurrentOil { get; set; }
        string FuelType { get; set; }

        float RemainOilAmount();
    }


}

