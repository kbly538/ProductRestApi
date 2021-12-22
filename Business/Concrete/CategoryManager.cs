using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    class CategoryManager : ICategoryService
    {
        ICategoryDAL _CategoryDAL;


        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _CategoryDAL = categoryDAL;
        }

        

        IDataResult<List<Category>> ICategoryService.GetList()
        {
            return new SuccessDataResult<List<Category>>(_CategoryDAL.GetList().ToList());
        }
    }
}
