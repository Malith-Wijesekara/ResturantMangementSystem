using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTasteApp.Models;

namespace MyTasteApp.DataAccess.Data.Repository.IRepository
{
    public interface IFoodTypeRepository : IRepository<FoodType>
    {
        IEnumerable<SelectListItem> GetFoodTypeListForDropDown();

        void Update(FoodType foodType);
    }
}