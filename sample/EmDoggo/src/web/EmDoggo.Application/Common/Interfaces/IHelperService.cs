using System;
using System.Collections.Generic;

namespace EmDoggo.Application.Common.Interfaces
{
    public interface IHelperService
    {
        void CreateFoodGalleryFolder(Guid foodId);
        List<string> GetFoodPictures(Guid foodId);
        void DeleteFoodGalleryFolder(Guid foodId);
    }
}
