using System;

using odev_3.DataAccess.Abstract;
using odev_3.DataAccess.Entities;


namespace odev_3.Business;


public class CourseManeger
{
    
    private readonly ICourseDal _coursedal;



	public CourseManeger(ICourseDal courseDal)
	{
        _coursedal = courseDal;

	}
    public List<Course> GetAll()
    {
        //

        return _coursedal.GetAll();

    }
}


