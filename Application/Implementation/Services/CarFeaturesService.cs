using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;

namespace Application.Implementation.Services
{
    class CarFeaturesService : ICarFeaturesService
    {
        private ICarFeaturesRepository _carFeaturesRepository;

        public CarFeaturesService(ICarFeaturesRepository carFeaturesRepository)
        {
            _carFeaturesRepository = carFeaturesRepository;
        }

        public void Delete(int id)
        {
            _carFeaturesRepository.DeleteCarFeatures(id);
        }

        public CarFeatures GetCarFeatures()
        {
            return _carFeaturesRepository.GetCarFeatures();
        }

        public void Post(CarFeatures carFeatures)
        {
            _carFeaturesRepository.AddCarFeatures(carFeatures);
        }

        public void Put(int id, CarFeatures carFeatures)
        {
            _carFeaturesRepository.EditCarFeatures(id, carFeatures);
        }
    }
}
