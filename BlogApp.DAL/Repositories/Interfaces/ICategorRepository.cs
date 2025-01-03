﻿using BlogAppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Interfaces
{
    public interface ICategorRepository : IRepository<Category>
    {
        void Delete(global::BlogAppBusiness.DTOs.Category.GetCategoryDto category);
    }
}
