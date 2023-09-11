using FS_Motors.Data;
using FS_Motors.Interfaces;
using FS_Motors.Models;
using Microsoft.EntityFrameworkCore;

namespace FS_Motors.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;

        public CarRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Car>> AddCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return await _context.Cars.ToListAsync();
        }

        public async Task<List<Car>?> DeleteCars(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car is null)
                return null;

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return await _context.Cars.ToListAsync();
        }

        public async Task<List<Car>> GetAllCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return cars;
        }

        public async Task<Car?> GetSinglCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car is null)
                return null;

            return car;
        }

        public async Task<List<Car>?> UpdateCar(int id, Car request)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car is null)
                return null;

            car.CarId = request.CarId;
            car.CarBuyingPrice = request.CarBuyingPrice;
            car.CarBuyingDate = request.CarBuyingDate;
            car.CarFinalPrice = request.CarFinalPrice;
            car.CarMaintenanceCost = request.CarMaintenanceCost;
            car.CarModelId = request.CarModelId;
            car.CarShowroomCost = request.CarShowroomCost;
            car.CarShowroomId = request.CarShowroomId;
            car.CarSellingDate = request.CarSellingDate;
            car.CarSellingPrice = request.CarSellingPrice;
            car.CarStatus = request.CarStatus;
            car.CarWorkshopId = request.CarWorkshopId;
            car.CarTotalCost= request.CarTotalCost;
            await _context.SaveChangesAsync();

            return await _context.Cars.ToListAsync();

        }


    }
}
