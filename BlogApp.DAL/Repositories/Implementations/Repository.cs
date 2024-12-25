using BlogApp.DAL.Context;
using BlogApp.DAL.Repositories.Interfaces;
using BlogAppCore.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        readonly BlogDBContext context;

        public Repository(BlogDBContext context)
        {
            this.context = context;
        }

        DbSet<TEntity> Table => context.Set<TEntity>();

        DbSet<TEntity> IRepository<TEntity>.Table => context.Set<TEntity>();

        async Task<TEntity> IRepository<TEntity>.Create(TEntity entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        void IRepository<TEntity>.Delete(TEntity entity)
        {
            Table.Remove(entity);
        }

        IQueryable<TEntity> IRepository<TEntity>.GetAll()
        {
            return Table;
        }

        TEntity IRepository<TEntity>.GetById(int id)
        {
            return Table.FirstOrDefault(x => x.Id == id);
        }

        async void IRepository<TEntity>.SaveChangesAsync()
        {
             await context.SaveChangesAsync();
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            Table.Update(entity);
        }
    }
}
