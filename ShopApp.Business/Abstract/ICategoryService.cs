﻿using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Entities;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
