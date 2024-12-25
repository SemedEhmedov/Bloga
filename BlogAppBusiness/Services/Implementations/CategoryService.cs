using AutoMapper;
using BlogApp.DAL.Repositories.Interfaces;
using BlogAppBusiness.DTOs.Category;
using BlogAppBusiness.Services.Interfaces;
using BlogAppCore.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAppBusiness.Services.Implementations
{
    internal class CategoryService:ICategoryService
    {
        readonly ICategorRepository _rep;
        readonly IMapper _mapper;

        public CategoryService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public CategoryService(ICategorRepository rep)
        {
            _rep = rep;
        }

        public GetCategoryDto GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException();
            }
            GetCategoryDto dto = _mapper.Map<GetCategoryDto>(_rep.GetById(id));
            return dto;
        }

        async Task<GetAllCategoryDto> ICategoryService.Create(CreateCategoryDto category)
        {
            if(await _rep.IsExsist(x => x.Name == category.Name))
            {
                throw new Exception();
            }
            var Category = _mapper.Map<Category>(category);
            var newCategory = await _rep.Create(Category);  
            await _rep.SaveChangesAsync();
            return _mapper.Map<GetCategoryDto>(newCategory);
        }

        GetCategoryDto ICategoryService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
