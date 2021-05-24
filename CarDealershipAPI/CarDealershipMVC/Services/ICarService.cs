using CarDealershipMVC.Models;
using System.Threading.Tasks;

namespace CarDealershipMVC.Services
{
    public interface ICarService
    {
        Task<CarResults> Search(int id);
        Task<CarResults> GetAll();
    }
}