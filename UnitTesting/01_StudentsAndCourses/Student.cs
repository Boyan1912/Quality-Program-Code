using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StudentsAndCourses
{
    public class Student
    {
        private const int MIN_VALUE_ID = 10000;
        private const int MAX_VALUE_ID = 99999;

        private string name;
        private int id;

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Id 
        { 
            get
            {
                return this.id;
            }
            set
            {
                if (value < MIN_VALUE_ID || value > MAX_VALUE_ID)
                {
                    throw new ArgumentOutOfRangeException(string.Format("id is out of range: {0}", value));
                }
                this.id = value;
            }
        }

        public List<Course> CoursesAttended { get; set; }

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            this.CoursesAttended = new List<Course>();
            School.CheckUniqueId(this.Id);
            School.AddStudents(this);
        }

        public void JoinCourse(Course course)
        {
            course.AddStudentsToCourse(this);
            this.CoursesAttended.Add(course);
        }

        public void LeaveCourse(Course course)
        {
            course.RemoveStudentsFromList(this);
            this.CoursesAttended.Remove(course);
        }

    }
}
