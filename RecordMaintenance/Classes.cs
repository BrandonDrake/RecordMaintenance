using System;
using System.Collections.Generic;

namespace RecordMaintenance
{
    /// <summary>
    /// Sets the general properties of the classes for each course
    /// </summary>
    /// 
    public class Classes
    {
        #region Constructors
        public Classes(){ }

        public Classes(string courseID, DateTime beginDate, DateTime endDate, TypeOfClass classType = TypeOfClass.Not_Defined) 
        {
            if (!string.IsNullOrWhiteSpace(courseID))
            {
                if (VerifyCourseFound(courseID))
                {
                    ClassCourseID = courseID;
                }
                else
                {
                    Console.WriteLine("Invalid Course ID");
                }
            }
            BeginDate = beginDate;
            EndDate = endDate;
            ClassType = classType;
        }

        public Classes(string courseID, DateTime beginDate, DateTime endDate, string className, string url, string browser, TypeOfClass classType = TypeOfClass.Online) : this(courseID, beginDate, endDate)
        {
            ClassType = classType;

            OnlineClassInfo = new OnlineClass()
            {
                Name = className,
                URL = url,
                Browser = browser
            };
        }

        public Classes(string courseID, DateTime beginDate, DateTime endDate, string className, string building, int roomNumber, TypeOfClass classType = TypeOfClass.Face_to_Face) : this(courseID, beginDate, endDate)
        {
            ClassType = classType;

            F2FClassInfo = new FaceToFace()
            {
                ClassName = className,
                Building = building,
                RoomNumber = roomNumber
            };

        }
       
        public Classes(Classes baseClass) : this(baseClass.ClassCourseID, baseClass.BeginDate, baseClass.EndDate)
        {

        }
        #endregion



        #region Properties
        public string ClassCourseID { get;  set; }
        public DateTime BeginDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public TypeOfClass ClassType { get; set; }
        public OnlineClass OnlineClassInfo { get; set; }
        public FaceToFace F2FClassInfo { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Itterates Courses list to actually compare course ID's
        /// </summary>
        /// <param name="courseId">Class information to compare</param>
        /// <returns></returns>
        private bool VerifyCourseFound(string courseId)
        {
            bool courseFound = false;
            

            foreach(var course in CourseRepository.CourseDictionary())
            {
                if (course.Key == courseId )
                {
                   courseFound = true;
                   break;
                }
                
            }

            return courseFound;
        }



        /// <summary>
        /// Adds the Online class information to an existing class object        
        /// </summary>
        /// <param name="baseClass">Takes the base class Key</param>
        /// <param name="name">Sets the class name</param>
        /// <param name="url">sets the class URL</param>
        /// <param name="browser">Sets the class Browser</param>
        public Classes AddOnlineToExistingClass(string baseClass, string name, string url, string browser)
        {
            var ClassDictionary = new ClassRepository().ClassDictionary();
            var neededClass = ClassDictionary[baseClass];

            neededClass.OnlineClassInfo = new OnlineClass(neededClass ,name, url, browser);

            return neededClass;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string classes = $"Course ID({ClassCourseID}), Begin Date({BeginDate}), End Date({EndDate}), Class Type({ClassType})";

            if(OnlineClassInfo != null)
            {
                if(!string.IsNullOrWhiteSpace(OnlineClassInfo.Name))
                {
                    classes += $", Class Name({OnlineClassInfo.Name}), URL({OnlineClassInfo.URL}), Browser({OnlineClassInfo.Browser})";
                }
            }

            if(F2FClassInfo != null)
            {
                if (!string.IsNullOrWhiteSpace(F2FClassInfo.ClassName))
                {
                    classes += $", Class Name({F2FClassInfo.ClassName}), Building({F2FClassInfo.Building}), Room Number({F2FClassInfo.RoomNumber})";
                }
            }
            return classes;
        }
        #endregion
    }
}

