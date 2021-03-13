using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ICarRepository
    {
        void AddCar(Car car);
        void EditCar(int id, Car carToEdit);
        void DeleteCar(int id);
        List<Car> GetAllCar();
        Car GetCarById(int id);
    }
}
