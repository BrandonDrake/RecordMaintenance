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
        public void ClassesTest()
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
            var expected = "IT412";

            //Act
            var classFinal = classes.AddOnlineToExistingClass("CS1234", "IT412", "www.123.com", "Firefox");
            var actual = classFinal.OnlineClassInfo.Name;
            

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}