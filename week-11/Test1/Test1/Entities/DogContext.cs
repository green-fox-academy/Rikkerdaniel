using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Entities
{
    public class DogContext : DbContext
    {
        public DogContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<DogModel> DogModels { get; set; }
    }
}
