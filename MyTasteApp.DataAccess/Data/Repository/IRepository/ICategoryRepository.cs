using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTasteApp.Models;

namespace MyTasteApp.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);
    }
}