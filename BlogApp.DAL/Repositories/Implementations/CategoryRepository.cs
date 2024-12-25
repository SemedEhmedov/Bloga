using BlogApp.DAL.Context;
using BlogApp.DAL.Repositories.Interfaces;
using BlogAppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Implementations
{
    internal class CategoryRepository:Repository<Category>,ICategorRepository
    {
        public CategoryRepository(BlogDBContext context):base(context) { }
    }
}
