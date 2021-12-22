using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Product
            builder.RegisterType<ProductManager>().As<ICategoryService>();
            builder.RegisterType<EntityFrameworkProductDal>().As<IProductDAL>();
            // Category
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EntityFrameworkCategoryDal>().As<ICategoryDAL>();

        }
    }
}
