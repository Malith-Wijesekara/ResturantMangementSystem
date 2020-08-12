using MyTasteApp.Models;

namespace MyTasteApp.DataAccess.Data.Repository.IRepository
{
    public interface IMenuItemRepository: IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
    }
}