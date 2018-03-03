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
    public class ClassesTests
    {
        [TestMethod()]
        public void baseClassesTest()
        {
            //Arrange
            var expected = "Course ID(CS1234), Begin Date(1/2/2018 12:00:00 AM), End Date(2/2/2018 12:00:00 AM), Class Type(Online)";
            var expected2 = "Course ID(CS1234), Begin Date(1/2/2018 12:00:00 AM), End Date(2/2/2018 12:00:00 AM), Class Type(Not_Defined)";

            //Act
            var actual = new Classes("CS1234", DateTime.Parse("1/2/18"), DateTime.Parse("2/2/18"), TypeOfClass.Online);
            var actual2 = new Classes("CS1234", DateTime.Parse("1/2/18"), DateTime.Parse("2/2/18"));

            //Assert
            Assert.AreEqual(expected, actual.ToString());
            Assert.AreEqual(expected2, actual2.ToString());
        }

        [TestMethod()]
        public void AddToExistingClassTest()
        {
            //Arrange
            var classes = new Classes();
            var onlineClass = new OnlineClass();
            var expected = "Course ID(CS1234), Begin Date(1/2/2018 12:00:00 AM), End Date(2/28/2018 12:00:00 AM), Class Type(Online), Class Name(IT412), URL(www.123.com), Browser(Firefox)";

            //Act
            var classFinal = classes.AddOnlineToExistingClass("CS1234", "IT412", "www.123.com", "Firefox");
            var actual = classFinal;
            

            //Assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CompositionOnlineClassTest()
        {
            //Arrange
            var expected = "Course ID(CS2345), Begin Date(3/2/2018 12:00:00 AM), End Date(4/2/2018 12:00:00 AM), Class Type(Online), Class Name(IT424), URL(www.234.com), Browser(Chrome)";

            //Act
            var olClass = new Classes(courseID: "CS2345", beginDate: DateTime.Parse("3/2/2018"), endDate: DateTime.Parse("4/2/2018"), className: "IT424", url: "www.234.com", browser: "Chrome");
            var actual = olClass.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompositionF2FClassTest()
        {
            //Arrange
            var expected = "Course ID(CS2345), Begin Date(3/2/2018 12:00:00 AM), End Date(4/2/2018 12:00:00 AM), Class Type(Face_to_Face), Class Name(IT327), Building(IT Hall), Room Number(234)";

            //Act
            var f2fClass = new Classes(courseID: "CS2345", beginDate: new DateTime(2018, 3, 2), endDate: new DateTime(2018, 4, 2), className: "IT327", building: "IT Hall", roomNumber: 234);
            var actual = f2fClass.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}