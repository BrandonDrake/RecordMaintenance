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
    public class OnlineClassTests
    {
        [TestMethod()]
        public void OnlineClassTest()
        {
            //Arrange
            var expected = "Class Name(IT412), URL(www.123.com), Browser(Firefox)";
            var expected2 = "Course ID(CS1234), Begin Date(1/2/2018 12:00:00 AM), End Date(2/2/2018 12:00:00 AM), Class Type(Online), Class Name(IT412), URL(www.123.com), Browser(Firefox)";
            var expected3 = "Course ID(CS2345), Begin Date(3/2/2018 12:00:00 AM), End Date(4/2/2018 12:00:00 AM), Class Type(Online), Class Name(IT424), URL(www.234.com), Browser(Chrome)";

            //Act
            OnlineClass olClass = new OnlineClass(name: "IT412", URL: "www.123.com", browser: "Firefox");
            string actual = olClass.ToString();

            OnlineClass olClass2 = new OnlineClass(name: "IT412", URL: "www.123.com", browser: "Firefox", classCourseID: "CS1234", beginDate: DateTime.Parse("1/2/18"), endDate: DateTime.Parse("2/2/18"));
            string actual2 = olClass2.ToString();

            var programming = new Classes(courseID: "CS2345", beginDate: DateTime.Parse("3/2/18"), endDate: DateTime.Parse("4/2/18"));
            OnlineClass olClass3 = new OnlineClass(programming, name: "IT424", URL: "www.234.com", browser: "Chrome");
            string actual3 = olClass3.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod()]
        public void UpdateURLTest()
        {
            //Arrange
            var expected = "www.123.com";
            var expected2 = "www.URL2.com";

            //Act
            OnlineClass olClass = new OnlineClass(name: "IT412", URL: "www.123.com", browser: "Firefox");
            string actual = olClass.URL;

            olClass.UpdateURL("www.URL2.com");
            string actual2 = olClass.URL;

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}