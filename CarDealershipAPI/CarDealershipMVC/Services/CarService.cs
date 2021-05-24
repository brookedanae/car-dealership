using CarDealershipMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarDealershipMVC.Services
{
    public class CarService : ICarService
    {
        private readonly HttpClient _client;

        public CarService(HttpClient client)
        {
            _client = client;
        }

        public async Task<CarResults> GetAll()
        {
            return await _client.GetFromJsonAsync<CarResults>("api/car");
        }

        public async Task<CarResults> Search(int id)
        {
            return await _client.GetFromJsonAsync<CarResults>($"api/car/{id}");
        }
    }
}
