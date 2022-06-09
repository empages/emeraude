using System;
using System.Threading.Tasks;

namespace EmDoggo.Core.Data;

public class DataSeeder
{
    private readonly EntityContext context;

    public DataSeeder(EntityContext context)
    {
        this.context = context;
    }
    
    public async Task SeedAsync()
    {
        var owner1 = new Owner
        {
            Id = new Guid("45f8f8a5-7dc1-40d9-a8db-f6ce88f71a7f"),
            Name = "Ivan Ivanov",
            Address = "Burgas 056"
        };

        var owner2 = new Owner
        {
            Id = new Guid("76427fe9-086e-4a82-ada2-7c0306baee86"),
            Name = "Georgi Georgiev",
            Address = "Sofia 02"
        };

        var dog1 = new Dog
        {
            Id = new Guid("ec562ee6-976b-4321-9eac-7b4fcb6e72bc"),
            Name = "Jake",
            Breed = DogBreed.Chihuahua,
            Type = DogType.BestGuard,
            Owner = owner1,
        };
        
        var dog2 = new Dog
        {
            Id = new Guid("08ecd806-56fe-42bd-a6b9-fe3496320b87"),
            Name = "Michael",
            Breed = DogBreed.Pomeranian,
            Type = DogType.KidFriendly,
            Owner = owner1,
        };
        
        var dog3 = new Dog
        {
            Id = new Guid("c913b244-33a6-47bb-bd1a-4dc373a4fde1"),
            Name = "Simon",
            Breed = DogBreed.Dobermann,
            Type = DogType.BestWatch,
            Owner = owner2,
        };
        
        this.context.Owners.AddRange(owner1, owner2);
        this.context.Dogs.AddRange(dog1, dog2, dog3);
        
        await this.context.SaveChangesAsync();
    }
}