using System.Linq;
using MyTasteApp.DataAccess.Data.Repository.IRepository;
using MyTasteApp.Models;

namespace MyTasteApp.DataAccess.Data.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly MyTasteAppIdentityDbContext _db;

        public MenuItemRepository(MyTasteAppIdentityDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MenuItem menuItem)
        {
            var menuItemFromDb = _db.MenuItem.FirstOrDefault(menuItem => menuItem.Id == menuItem.Id);
            menuItemFromDb.Name = menuItem.Name;
            menuItemFromDb.Description = menuItem.Description;
            menuItemFromDb.CategoryId = menuItem.CategoryId;
            menuItemFromDb.FoodTypeId = menuItem.FoodTypeId;
            menuItemFromDb.Price = menuItem.Price;

            if(menuItemFromDb.Image != null){
                menuItemFromDb.Image = menuItem.Image;
            }
            _db.SaveChanges();

        }
    }
}