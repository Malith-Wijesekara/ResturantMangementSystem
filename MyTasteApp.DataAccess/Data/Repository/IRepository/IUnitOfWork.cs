using System;

namespace MyTasteApp.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category {get;}
        IFoodTypeRepository FoodType {get;}

        void Save();
    }
}