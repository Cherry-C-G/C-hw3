using System;

namespace oop6
{
    // Interface
    interface IPersonService
    {
        void calculateAge(); // interface method (does not have a body)
        void calculateSalary(); // interface method (does not have a body)
        void getAddress();  // interface method (does not have a body)
    }

    interface ICourseService
    {
        void listOfStudents(); // interface method (does not have a body)
    }
    interface IStudentService : IPersonService
    {
        void takeCourses(); // interface method (does not have a body)
        void calculateGPA();


    }
    interface IInstructorService : IPersonService
    {
        void departmentName();
        bool isHeadofDepartment(); // interface method (does not have a body)
        void bonus();

    }
    interface IDepartmentService
    {
        void head(); // interface method (does not have a body)
        void budget();
        void listOfCourses();
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}