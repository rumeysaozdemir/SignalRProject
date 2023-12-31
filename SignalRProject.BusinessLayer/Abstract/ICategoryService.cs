﻿using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
    }
}
