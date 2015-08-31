using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string CourseName;
        private string CourseID;
        private string Lecturer = "Staff";
        private int MaxStudents = 30;
        private int NumStudents;

        //function method
        public Course()
        {
            MaxStudents = 30;
        }
        public Course(string CourseName, string CourseID)
        {
            this.CourseName = CourseName;
            this.CourseID = CourseID;
        }
        public Course(string CourseName, string CourseID, string Lecturer)
        {
            this.CourseName = CourseName;
            this.CourseID = CourseID;
            this.Lecturer = Lecturer;
            MaxStudents = 30;
        }
        public Course(string CourseName, string CourseID, string Lecturer, int MaxStudents)
        {
            this.CourseName = CourseName;
            this.CourseID = CourseID;
            this.Lecturer = Lecturer;
            this.MaxStudents = MaxStudents;
        }

        public void setCourseName(string CourseName)
        {

            this.CourseName = CourseName;


        }
        public string getCousename()
        {

            return CourseName;

        }
        public void setCourseID(string CourseID)
        {
            int number;

            bool check = int.TryParse(CourseID, out number);
            if (CourseID.Length != 6 || check == false)
            {
                Console.WriteLine("261200: error try setting invalid CourseID!");
            }
            else
            {
                this.CourseID = CourseID;
            }
        }
        public string getCouseID()
        {

            return CourseID;

        }

        public void setLecturer(string Lecturer)
        {
            this.Lecturer = Lecturer;


        }
        public string getLecturer()
        {


            return Lecturer;
        }

        public void setMaxStudents(int MaxStudents)
        {
            if (MaxStudents >= NumStudents)
            {
                this.MaxStudents = MaxStudents;

            }
            else if (MaxStudents >= 0 || MaxStudents <= 80)
            {
                Console.WriteLine("261200: error try setting invalid Max No. Students!");             
            }

        }

        public int getMaxStudents()
        {

            return MaxStudents;
        }

        public void setNumStudents(int NumStudents)
        {
            if (NumStudents > MaxStudents)
            {
                Console.WriteLine("261200: error try setting invalid No. Students!");
            }
            else
            {
                this.NumStudents = NumStudents;
            }
        }
        public int getNumStudents()
        {

            return NumStudents;

        }
        public override string ToString()
        {
            return "Course: " + CourseName + " (" + CourseID + "), " + "Lecturer: " + Lecturer + ", " + "has " + NumStudents + " students," + " [max : " + MaxStudents + "]";
        }
    }
}
