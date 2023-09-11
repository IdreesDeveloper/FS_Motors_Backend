using FS_Motors.Models;

namespace FS_Motors.Interfaces
{
    public interface ICarRepository
    {

            public Task<List<Car>> GetAllCars();
            Task<Car?> GetSinglCar(int id);
            Task<List<Car>> AddCar(Car Car);
            Task<List<Car>?> UpdateCar(int id, Car request);
            Task<List<Car>?> DeleteCars(int id);
        }
    }


