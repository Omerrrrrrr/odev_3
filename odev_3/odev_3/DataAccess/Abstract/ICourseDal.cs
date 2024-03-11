using System;
using odev_3.DataAccess.Entities;

namespace odev_3.DataAccess.Abstract
{
	public interface ICourseDal
	{

        List<Course> GetAll();

        void Add(Course course);
       
        void Remove(Course course);

        void Updte(Course course);


    }
}

