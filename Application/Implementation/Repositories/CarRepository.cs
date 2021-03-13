using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Implementation
{
    public class CarRepository : ICarRepository
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CarRepository(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void AddCar(Car car)
        {
            _applicationDbContext.Cars.Add(car);
            _applicationDbContext.SaveChanges();
        }

     
        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCar(int id, Car carToEdit)
        {
            var car = _applicationDbContext.Cars.Find(id);

            car.CarFeatures = carToEdit.CarFeatures;
            car.CarModel = carToEdit.CarModel;
            car.Currency = carToEdit.Currency;
            car.Description = carToEdit.Description;
            car.Price = carToEdit.Price;
            car.GelPrice = carToEdit.GelPrice;
            car.Image = carToEdit.Image;
            car.ManufactureDate = carToEdit.ManufactureDate;

            _applicationDbContext.SaveChanges();
        }

       

        public List<Car> GetAllCar()
        {
            return _applicationDbContext.Cars.ToList();
        }

        public Car GetCarById(int id)
        {
            return _applicationDbContext.Cars.FirstOrDefault(x => x.Id == id);
        }

        
    }
}
