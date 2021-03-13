using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public CarModel CarModel { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public double GelPrice { get; set; }

        public CarFeatures CarFeatures { get; set; }
        public int CarFeaturesId { get; set; }
    }

}
