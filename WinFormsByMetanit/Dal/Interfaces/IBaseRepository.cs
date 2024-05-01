using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;

namespace WinFormsByMetanit.Dal.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity);
        Task CreateAll(List<T> entities);
        IQueryable<T> GetAll();
        Task<bool> Delete(int id);
        Task<T> Update(T entity);


    }
}
