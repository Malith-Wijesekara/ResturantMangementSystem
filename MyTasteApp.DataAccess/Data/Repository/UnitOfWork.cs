using MyTasteApp.DataAccess.Data.Repository.IRepository;


namespace MyTasteApp.DataAccess.Data.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MyTasteAppIdentityDbContext _db;
        public ICategoryRepository Category {get; private set;}

        public IFoodTypeRepository FoodType {get; private set;}

        public UnitOfWork(MyTasteAppIdentityDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            FoodType = new FoodTypeRepository(_db);
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