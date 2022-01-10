using System;
using System.Collections.Generic;
using AutoMapper;
using EmDoggo.Domain.Common;
using EmDoggo.Domain.Entities;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Mapping;
using Emeraude.Application.Models;

namespace EmDoggo.Admin.EmPages.Food;

public class FoodEmPageModel : IEmPageModel, IMapFrom<Domain.Entities.Food>
{
    public string Id { get; set; }
    
    public string Name { get; set; }

    public FoodManufacturer Manufacturer { get; set; }
    
    public string ImageUrl { get; set; }

    public DateModel PackageDate { get; set; }

    public DateModel? ExpirationDate { get; set; }
}