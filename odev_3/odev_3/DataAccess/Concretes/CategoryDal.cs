using System;
using odev_3.DataAccess.Abstract;
using odev_3.DataAccess.Entities;

namespace odev_3.DataAccess.Concretes;


    
public class CategoryDal:ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {

        Category category1 = new Category();
        category1.Id = 1;
        category1.Name = "Proglama";

        Category category2 = new Category();
        category2.Id = 2;
        category2.Name = "Yazilim";


        categories = new List<Category> { category1, category2 };

    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Add(Category category)
    {
        categories.Add(category);
        Console.WriteLine("Kategori eklendi. ");
    }

    public void Remove(Category category)
    {
        categories.Remove(category);
        Console.WriteLine("Kategori silindi. ");
    }

    public void Update(Category category)
    {
        
        Console.WriteLine("Kategori guncellendi. ");
    }
}


