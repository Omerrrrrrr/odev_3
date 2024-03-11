


using odev_3.Business;
using odev_3.DataAccess.Concretes;
using odev_3.DataAccess.Entities;

CourseManeger courseManager = new CourseManeger(new CourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0; i <courses.Count; i++)
{

    Console.WriteLine($"{i + 1}.kurs = {courses[i].Name}");

}