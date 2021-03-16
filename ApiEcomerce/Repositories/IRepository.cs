using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IQueryable<TEntity> Gets();
        Task<TEntity> Get(int ID);
        Task<TEntity> AddAnsync(TEntity entity);
        void Remove(int ID);
        IQueryable<TEntity> GetsByMainCat(int MainCatID);
        IQueryable<TEntity> GetsByCat(int CatID);
        Task<TEntity> UpdateAsync();
    }
}
