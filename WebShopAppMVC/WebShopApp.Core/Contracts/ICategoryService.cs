﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShopAppMVC.Infrastructure.Data.Domain;

namespace WebShopApp.Core.Contracts
{
    public interface ICategoryService
    {

        List<Category> GetCategories();
        Category GetCategoryById(int categoryId);

        List<Product> GetProductsByCategory(int categoryId);
    }
}
