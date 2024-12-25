using BlogAppCore.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()   
    {
        public DbSet<TEntity> Table { get; }
        public TEntity GetById(int id);
        public IQueryable<TEntity> GetAll();
        public Task<TEntity> Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public void SaveChangesAsync();
        public async Task<bool> IsExsist(Expression<Func<TEntity,bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }
    }
}
