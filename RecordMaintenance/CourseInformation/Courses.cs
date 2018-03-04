using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RecordMaintenance
{
    public class Courses
    {
        #region Constructors
        public Courses(){ }
        
        
        public Courses (string courseID, string courseName, int creditHours, string courseDescription) //: this()
        {
            if (CourseInputVerification(courseID))
            {
                CourseID = courseID;
            }
            CourseName = courseName;
            CreditHours = creditHours;
            CourseDescription = courseDescription;
        }
        #endregion

        #region Properties
        public string CourseName { get; set; }
        public string CourseID { get; set; }
        public int CreditHours { get; set; }
        public string CourseDescription { get; set; }
        
        #endregion

        #region Methods
        
         /// <summary>
         /// Verify that the course name does not contain any symbols
         /// </summary>
         /// <param name="courseID">Course ID entered by user</param>
         /// <returns></returns>
         public bool CourseInputVerification (string courseID)
        {
            bool noSymbols = false;
            string newID= "";

            if(courseID.Length == 6)
            {
                MatchCollection mc = Regex.Matches(courseID, @"\w");
            
                for(int i = 0; i < mc.Count; i++)
                {
                    newID += mc[i];
                }
           
                    if (newID.Equals(courseID))
                    {
                        noSymbols = true;
                    }
                    else
                    {
                        Console.WriteLine("Course ID must only be letters and numbers");
                        Console.WriteLine("Please enter a valid Course ID");
                        //this.CourseID = Console.ReadLine();
                        //CourseInputVerification(CourseID);
                    }
            }
            else 
            {
                Console.WriteLine("Course ID must be 6 characters");
                Console.WriteLine("Please enter a valid Course ID");
                //this.CourseID = Console.ReadLine();
                //CourseInputVerification(CourseID);
            }

            return noSymbols;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string course = $"Course Information: Course ID({CourseID}), Course Name({CourseName}), Credit Hours({CreditHours}), Course Description({CourseDescription})";
            return course;
        }
        #endregion


    }
}
