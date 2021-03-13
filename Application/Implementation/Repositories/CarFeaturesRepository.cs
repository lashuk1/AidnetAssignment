using Application.Interfaces;
using Application.Interfaces.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Implementation.Repositories
{
    class CarFeaturesRepository : ICarFeaturesRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CarFeaturesRepository (IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void AddCarFeatures(CarFeatures carFeatures)
        {
            _applicationDbContext.CarFeatures.Add(carFeatures);
            _applicationDbContext.SaveChanges();
        }

        public void DeleteCarFeatures(int id)
        {
            var carFeatures = _applicationDbContext.CarFeatures.Find(id);

            _applicationDbContext.CarFeatures.Remove(carFeatures);

            _applicationDbContext.SaveChanges();
        }

        public void EditCarFeatures(int id, CarFeatures carFeaturesToEdit)
        {
            var carfeature = _applicationDbContext.CarFeatures.Find(id);
            carfeature.Abs = carFeaturesToEdit.Abs;
            carfeature.Alarm = carFeaturesToEdit.Alarm;
            carfeature.Bluetooth = carFeaturesToEdit.Bluetooth;
            carfeature.Display = carFeaturesToEdit.Display;
            carfeature.ElWindows = carFeaturesToEdit.ElWindows;
            carfeature.Hatch = carFeaturesToEdit.Hatch;
            carfeature.MultiFuncSteeringWheel = carFeaturesToEdit.MultiFuncSteeringWheel;
            carfeature.Navigation = carFeaturesToEdit.Navigation;
            carfeature.ParkingControl = carFeaturesToEdit.ParkingControl;
            _applicationDbContext.SaveChanges();

        }

        public CarFeatures GetCarFeatures()
        {
            return new CarFeatures();
        }

        public List<CarFeatures> GetAllCarFeatures()
        {
            return _applicationDbContext.CarFeatures.ToList();
        }

        public CarFeatures GetCarfeaturesById(int id)
        {
            return _applicationDbContext.CarFeatures.FirstOrDefault(x => x.Id == id);
        }

    }
}
