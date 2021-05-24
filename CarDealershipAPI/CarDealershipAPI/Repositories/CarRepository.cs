using CarDealershipAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealershipAPI.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDbContext _context;

        public CarRepository(CarDbContext context)
        {
            _context = context;
        }

        public async Task Create(Data.Models.Car model)
        {
            _context.Cars.Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var delete = await _context.Cars.FindAsync(id);
            _context.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Data.Models.Car>> GetAll()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Data.Models.Car> Get(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        Task ICarRepository.Update(int id, Data.Models.Car model)
        {
            throw new System.NotImplementedException();
        }
    }
}
