using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    interface ICarFeaturesRepository
    {
        CarFeatures GetCarFeatures();
        void AddCarFeatures(CarFeatures carFeatures);
        void EditCarFeatures(int id, CarFeatures carFeaturesToEdit);
        void DeleteCarFeatures(int id);
    }
}
