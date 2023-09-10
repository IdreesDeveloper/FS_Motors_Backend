using FS_Motors.Models;

namespace FS_Motors.Interfaces
{
    public interface ICarInterface
    {
       public Task<List<Car>> GetAllCars();
        Task<Car?> GetSingleCar(int id);
        Task<List<Car>> AddCar(Car car);
        Task<List<Car>?> UpdateCar(int id, Car request);
        Task<List<Car>?> DeleteCar(int id);
    }
}
