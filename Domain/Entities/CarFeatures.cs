using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class CarFeatures
    {
        public int Id { get; set; }

        public bool Abs { get; set; }
        public bool ElWindows { get; set; }
        public bool Hatch { get; set; }
        public bool Bluetooth { get; set; }
        public bool Alarm { get; set; }
        public bool ParkingControl { get; set; }
        public bool Navigation { get; set; }
        public bool Display { get; set; }
        public bool MultiFuncSteeringWheel { get; set; }
    }
}
