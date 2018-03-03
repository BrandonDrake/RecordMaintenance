using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordMaintenance.Tests
{
    [TestClass()]
    public class CoursesTests
    {
        [TestMethod()]
        public void CourseInputVerificationTest()
        {
            //Arange
            bool expected = true;
            bool expected2 = false;
            bool expected3 = false;

            //Act
            var course = new Courses();
            var actual = course.CourseInputVerification("CS1234");
            var actual2 = course.CourseInputVerification("C$1234");
            var actual3 = course.CourseInputVerification("CS$1234");


            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod()]
        public void CoursesTest()
        {

            //Arrange
            var expected = "Course Information: Course ID(CS1234), Course Name(Course1), Credit Hours(3), Course Description(Desc1)";
            var expected2 = "Course Information: Course ID(), Course Name(Course1), Credit Hours(3), Course Description(Desc1)";



            //Act
            var actual = new Courses("CS1234", "Course1", 3, "Desc1").ToString();
            var actual2 = new Courses("C$1234", "Course1", 3, "Desc1").ToString();

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);

        }
    }
}