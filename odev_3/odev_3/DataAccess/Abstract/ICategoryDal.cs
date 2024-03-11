using System;
using odev_3.DataAccess.Entities;

namespace odev_3.DataAccess.Abstract
{
	public interface ICategoryDal
	{

		List<Category> GetAll();

		void Add(Category category);

        void Remove(Category category);

        void Update(Category category);

    }
}

