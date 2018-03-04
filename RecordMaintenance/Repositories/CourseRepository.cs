using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordMaintenance
{
    public static class CourseRepository
    {
        public static Dictionary<string, Courses> CourseDictionary() 
        {
            
            var courseDictionary = new Dictionary<string, Courses>()
            {
                {"CS1234", new Courses(){CourseID = "CS1234", CourseName = "Course1", CreditHours = 3, CourseDescription = "Desc1"} },
                {"CS2345", new Courses(){CourseID = "CS2345", CourseName = "Course2", CreditHours = 3, CourseDescription = "desc2"} },
                {"CS3456", new Courses(){CourseID = "CS3456", CourseName = "Course3", CreditHours = 3, CourseDescription = "desc3"} },
                {"CS4567", new Courses(){CourseID = "CS4567", CourseName = "Course4", CreditHours = 3, CourseDescription = "desc4"} },
                {"CS5678", new Courses(){CourseID = "CS5678", CourseName = "Course5", CreditHours = 3, CourseDescription = "desc5"} },
            };

            return courseDictionary; 
        }
    }
}
