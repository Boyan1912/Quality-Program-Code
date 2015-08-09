using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StudentsAndCourses
{
    public static class School
    {
        private static List<Student> allStudents = new List<Student>();
        private static List<Course> allCourses = new List<Course>();

        public static List<Student> AllStudents 
        { 
            get
            {
                return allStudents;
            }
            set
            {
                allStudents = value;
            }
        }

        public static List<Course> AllCourses 
        { 
            get
            {
                return allCourses;
            }
            set
            {
                allCourses = value;
            }
        }

        public static void AddStudents(params Student[] students)
        {
            AllStudents.AddRange(students);
        }

        public static void AddCourses(params Course[] courses)
        {
            AllCourses.AddRange(courses);
        }

        public static void CheckUniqueId(int newID)
        {
            bool iDAlreadyExists = AllStudents.Any(x => x.Id == newID);

            if (AllStudents.Any(x => x.Id == newID))
            {
                throw new ArgumentException("IDs must be unique!");
            }
        }

        


    }
}
