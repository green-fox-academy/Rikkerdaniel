using System.Collections.Generic;
using Test1.Entities;
using Test1.Models;

namespace Test1.Repositories
{
    public class DogRepository
    {
        public DogContext DogContext { get; set; }

        public DogRepository(DogContext dogContext)
        {
            DogContext = dogContext;
        }

        public List<DogModel> GetDogs()
        {
            List<DogModel> DogLIst = new List<DogModel>();

            foreach (var item in DogContext.DogModels)
            {
                DogLIst.Add(item);
            }

            return DogLIst;
        }

        public void AddDog()
        {
            DogModel newDog = new DogModel();
            newDog.Age = 2;
            newDog.Name = "pista";
            DogContext.Add(newDog);
            DogContext.SaveChanges();
        }
    }
}
