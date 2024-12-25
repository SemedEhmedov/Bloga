using BlogAppBusiness.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAppBusiness.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<GetAllCategoryDto> Create(CreateCategoryDto category);
        GetCategoryDto GetById(int id);
    }
}
