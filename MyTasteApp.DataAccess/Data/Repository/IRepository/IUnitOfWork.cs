using System;

namespace MyTasteApp.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category {get;}

        void Save();
    }
}