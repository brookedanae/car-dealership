using CarDealershipAPI.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealershipAPI.Repositories
{
    public interface ICarRepository
    {
        Task Create(Data.Models.Car model);
        Task Delete(int id);
        Task<Car> Get(int id);
        Task<List<Car>> GetAll();
        Task Update(int id, Car model);
    }
}