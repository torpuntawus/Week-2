using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string Name = "John Doe";
        private string StudentID = "Unknow";
        private int YearOfBirth = 20;
        private bool isActive = true;

        public Student()
        {

            YearOfBirth = 20;
            isActive = false;
        }
        public Student(string Name, string StudentID)
        {

            this.Name = Name;
            this.StudentID = StudentID;

        }
        public Student(string Name, string StudentID, int YearOfBirth)
        {       
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = 2015-YearOfBirth;

        }
        public Student(string Name, string StudentID, int YearOfBirth, bool status)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = 2015-YearOfBirth;
            this.isActive = status;

        }

        //because not return
        public void setName(string Name)
        {
            this.Name = Name;
        }

        public string getName()
        {

            return "";


        }

        public void setStudent_id(string StudentID)
        {
            this.StudentID = StudentID;

        }
        public string getStudent_id()
        {

            return "";
        }
        public void setYearOfBirth(int YearOfBirth)
        {
            if (YearOfBirth < 1950 || YearOfBirth > 2000)
            {
                Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
            }
            else
            {
                this.YearOfBirth = 2015 - YearOfBirth;
            }
        }
        public int getYearOfBirth()
        {

            return 0;

        }

        public void setActive(bool status)
        {
            isActive = status;

        }
        public bool getActive()
        {

            return true;

        }
        public override string ToString()
        {
            if (isActive == true)
            {
                return Name + " (" + StudentID + ") " + "Age:" + YearOfBirth + " is active student";
            }
            else
            {
                return Name + " (" + StudentID + ") " + "Age:" + YearOfBirth + " is not active student";
            }


        }



    }
}
