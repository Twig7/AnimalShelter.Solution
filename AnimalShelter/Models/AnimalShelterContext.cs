using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Destination>()
                .HasData(
                  new Animal { AnimalId = 1, Name = "Chives", Species = "Cat", Age = 3, Gender = "Male" },
                  new Animal { AnimalId = 2, Name = "Rigatoni", Species = "Cat", Age = 4, Gender = "Male" },
                  new Animal { AnimalId = 3, Name = "Honeybun", Species = "Cat", Age = 1, Gender = "Female" },
                  new Animal { AnimalId = 4, Name = "Maple", Species = "Cat", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 5, Name = "Maggie", Species = "Dog", Age = 3, Gender = "Female" },
                  new Animal { AnimalId = 6, Name = "William", Species = "Dog", Age = 6, Gender = "Male" },
                  new Animal { AnimalId = 7, Name = "Trashcan", Species = "Dog", Age = 5, Gender = "Male" },
                  new Animal { AnimalId = 8, Name = "Toast", Species = "Cat", Age = 10, Gender = "Male" },
                  new Animal { AnimalId = 9, Name = "Strahd", Species = "Cat", Age = 100, Gender = "Male" },
                  new Animal { AnimalId = 10, Name = "Ted", Species = "Dog", Age = 5, Gender = "Male" },
                );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}                