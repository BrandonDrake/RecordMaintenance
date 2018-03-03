using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordMaintenance
{
    public class ClassRepository
    {
        public Dictionary<string, Classes> ClassDictionary()
        {

            var classDictionary = new Dictionary<string, Classes>()
            {
                {"CS1234", new Classes(){ClassCourseID = "CS1234", BeginDate = DateTime.Parse("1/2/2018"), EndDate = DateTime.Parse("2/28/2018"), ClassType = TypeOfClass.Online}},
                {"CS2345", new Classes(){ClassCourseID = "CS2345", BeginDate = DateTime.Parse("3/2/2018"), EndDate = DateTime.Parse("4/28/2018"), ClassType = TypeOfClass.Online}},
                {"CS3456", new Classes(){ClassCourseID = "CS3456", BeginDate = DateTime.Parse("5/2/2018"), EndDate = DateTime.Parse("6/28/2018"), ClassType = TypeOfClass.Face_to_Face}},
                {"CS4511", new Classes(){ClassCourseID = "CS4511", BeginDate = DateTime.Parse("7/2/2018"), EndDate = DateTime.Parse("8/28/2018")}},
            };

            return classDictionary;
        }
    }
}
