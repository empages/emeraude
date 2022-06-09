using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmDoggo.Core.Data;

public class Dog : Entity
{
    [Required]
    public string Name { get; set; }

    public DogType Type { get; set; }

    public DogBreed Breed { get; set; }

    public Guid OwnerId { get; set; }

    [ForeignKey(nameof(OwnerId))]
    public Owner Owner { get; set; }
}