using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface ICarFeaturesService
    {
        CarFeatures GetCarFeatures();
        void Post(CarFeatures carfeatures);
        void Put(int id, CarFeatures CarFeatures);
        void Delete(int id);
    }
}
