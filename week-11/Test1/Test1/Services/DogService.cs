using System.Collections.Generic;
using Test1.Models;
using Test1.Repositories;

namespace Test1.Services
{
    public class DogService
    {
        public DogRepository DogRepository { get; set; }

        public DogService(DogRepository dogRepository)
        {
            DogRepository = dogRepository;
        }

        public List<DogModel> GetDogs()
        {
            return DogRepository.GetDogs();
        }

        public void AddDog()
        {
            DogRepository.AddDog();
        }
    }
}
