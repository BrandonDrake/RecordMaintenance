using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordMaintenance
{
    public class OnlineClass : Classes
    {
        #region Constructors
        public OnlineClass() { }

        public OnlineClass(string name, string URL, string browser) : this(name, URL, browser, "", DateTime.Parse("1/1/1"), DateTime.Parse("1/1/1"))
        {
            
        }

        public OnlineClass(string name, string URL, string browser, string classCourseID, DateTime beginDate, DateTime endDate) :
            base(classCourseID, beginDate, endDate) 
        {
            this.Name = name;
            this.URL = URL;
            this.Browser = browser;
            ClassType = TypeOfClass.Online;
        }

        public OnlineClass(Classes baseClass, string name, string URL, string browser) : base(baseClass)
        {
            this.Name = name;
            this.URL = URL;
            this.Browser = browser;
            ClassType = TypeOfClass.Online;
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public string URL { get; set; }
        public string Browser { get; set; }
       

        #endregion

        #region Methods
        public void UpdateURL (string URL)
        {
            this.URL = URL;
        }

       
        #endregion

        #region overrides
        public override string ToString()
        {
            string onlineClass = "";
            
            if (!string.IsNullOrEmpty(ClassCourseID))
            {
                onlineClass = $"Course ID({ClassCourseID}), Begin Date({BeginDate}), End Date({EndDate}), Class Type({ClassType}), ";
            }

            onlineClass += $"Class Name({Name}), URL({URL}), Browser({Browser})";
            
            return onlineClass;
        }
        #endregion
    }
}
