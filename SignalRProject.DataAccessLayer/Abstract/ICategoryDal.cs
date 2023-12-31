﻿using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();

    }
}
