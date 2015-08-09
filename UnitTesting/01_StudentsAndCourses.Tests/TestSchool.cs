using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _01_StudentsAndCourses.Tests
{
    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentNameWithEmptyString()
        {
            Student someOne = new Student("", 10001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentWithTooSmallIDNumber()
        {
            Student someOne = new Student("Pesho", 20);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentWithTooBigIDNumber()
        {
            Student someOne = new Student("Pesho", 9999999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentWithSameIDNumber()
        {
            Student someOne = new Student("Pesho", 20000);
            Student someOneElse = new Student("Gosho", 20000);
        }

        [TestMethod]
        public void TestStudentsJoinCourse()
        {
            School.AllStudents.Clear();
            School.AllCourses.Clear();
            for (int i = 0; i < 100; i++)
            {
                new Student("Pesho " + i.ToString(), 12000 + i).JoinCourse(new Course("TestCourse " + i.ToString()));
                Assert.AreEqual(i + 1, School.AllStudents.Count);
                Assert.AreEqual(i + 1, School.AllCourses.Count);    
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMoreThanMaximumAllowedNumberOfStudentsJoinACourse()
        {
            Course testCourse = new Course("");
            for (int i = 0; i < 31; i++)
            {
                new Student("Pesho " + i.ToString(), 88888 + i).JoinCourse(testCourse);
            }
        }

        [TestMethod]
        public void AddAnArrayOfStudentsToCourse()
        {
            School.AllCourses.Clear();
            School.AllStudents.Clear();

            var students = new Student[3] {
                new Student("Pesho", 11111), 
                new Student("Gosho", 11112), 
                new Student("Tosho", 11113)};

            var someCourse = new Course("");
            someCourse.AddStudentsToCourse(students);
            Assert.AreEqual(students.Length, someCourse.Students.Count);
            Assert.AreEqual(School.AllStudents.Count, students.Length);
            Assert.AreEqual(School.AllCourses.Count, 1);
        }

        [TestMethod]
        public void TestStudentsLeavingCourse()
        {
            School.AllCourses.Clear();
            School.AllStudents.Clear();
            Course testCourse = new Course("Tester");
            List<Student> newStudents = new List<Student>();

            for (int i = 0; i < 20; i++)
            {
                newStudents.Add(new Student("Pesho " + i.ToString(), 11000 + i));
                newStudents[i].JoinCourse(testCourse);
                bool studentIsOdd = i % 2 == 1;
                if (studentIsOdd)
                {
                    newStudents[i].LeaveCourse(testCourse);
                }
            }
            for (int i = 0; i < testCourse.Students.Count; i++)
            {
                Assert.AreEqual("Pesho " + (i + i).ToString(), testCourse.Students[i].Name);

                if (i % 2 == 1)
                {
                    Assert.AreEqual(newStudents[i].CoursesAttended.Count, 0);
                }
                else
                {
                    Assert.AreEqual(newStudents[i].CoursesAttended.Count, 1);
                }
            }
            Assert.AreEqual(School.AllStudents.Count, newStudents.Count);
        }

       static void Main()
       {
            
       }
    }
}
