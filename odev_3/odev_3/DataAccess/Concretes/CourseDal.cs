using System;
using odev_3.DataAccess.Abstract;
using odev_3.DataAccess.Entities;

namespace odev_3.DataAccess.Concretes;



public class CourseDal : ICourseDal
{
    List<Course> courses;


    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Teacher = "Engin Demirog";

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Programlamaya Giris icin Temel Kurs";
        course2.Teacher = "Engin Demirog";



        courses = new List<Course> { course1, course2 };


    }



    public List<Course> GetAll()
    {
        return courses;
    }


    public void Add(Course course)
    {
        courses.Add(course);
        Console.WriteLine("Kurs eklendi. ");
    }




    public void Remove(Course course)
    {
        courses.Remove(course);
        Console.WriteLine("Kurs silindi. ");
    }


    public void Updte(Course course)
    {

        Console.WriteLine("Kurs guncellendi. ");
    }

    
}
