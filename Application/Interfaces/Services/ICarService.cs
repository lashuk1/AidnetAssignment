using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ICarService
    {
        List<Car> Get();
        Car GetById(int id);
        void Post(Car car, string currencyApi);
        void Put(int id, Car car, string currencyApi);
        void Delete(int id);
    }
}
