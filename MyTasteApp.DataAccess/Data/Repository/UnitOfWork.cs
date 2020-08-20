using MyTasteApp.DataAccess.Data.Repository.IRepository;


namespace MyTasteApp.DataAccess.Data.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MyTasteAppIdentityDbContext _db;
        public ICategoryRepository Category {get; private set;}

        public IFoodTypeRepository FoodType {get; private set;}
        public IMenuItemRepository MenuItem {get; private set;}
        public IApplicationUserRepository ApplicationUser {get; private set;}
        public IShoppingCartRepository ShoppingCart {get; private set;}


        public UnitOfWork(MyTasteAppIdentityDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            FoodType = new FoodTypeRepository(_db);
            MenuItem = new MenuItemRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
        }

        

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}