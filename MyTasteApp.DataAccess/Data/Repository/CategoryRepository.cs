using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTasteApp.DataAccess.Data.Repository.IRepository;
using MyTasteApp.Models;

namespace MyTasteApp.DataAccess.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly MyTasteAppIdentityDbContext _db;

        public CategoryRepository(MyTasteAppIdentityDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.Category.Select(i => new SelectListItem(){
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(Category category)
        {            
            var objFromDb = _db.Category.FirstOrDefault(s => s.Id == category.Id);

            objFromDb.Name = category.Name;
            objFromDb.DisplayOrder = category.DisplayOrder;

            _db.SaveChanges();
        }
    }
}