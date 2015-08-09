using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StudentsAndCourses
{
    public class Course
    {
        private const int MAX_STUDENTS_IN_A_COURSE = 30;

        private List<Student> students;

        public List<Student> Students 
        { 
            get
            {
                return this.students;
            }
            
            private set
            {
                this.students = value;
            }
        }

        public string Name { get; set; }

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
            School.AddCourses(this);
        }

        public void AddStudentsToCourse(params Student[] students)
        {
            for (int i = 0; i < students.Length; i++ )
            {
                if (this.students.Count >= MAX_STUDENTS_IN_A_COURSE)
                {
                    throw new ArgumentOutOfRangeException("Maximum allowed number of students in a course exceeded!");
                }
                this.Students.Add(students[i]);
            }
        }

        public void RemoveStudentsFromList(params Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                this.Students.Remove(students[i]);
            }
        }
    }
}
