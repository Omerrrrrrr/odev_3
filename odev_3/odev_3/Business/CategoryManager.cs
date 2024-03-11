using System;

using odev_3.DataAccess.Abstract;
using odev_3.DataAccess.Entities;


namespace odev_3.Business;


public class CategoryManager
{

    private readonly ICategoryDal _categoryDal;

    public CategoryManager(Category categoryDal)
    {
        _categoryDal = (ICategoryDal) categoryDal;

    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

   
}