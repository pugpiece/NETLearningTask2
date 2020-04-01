using System;
using System.Collections.Generic;
using System.Text;

namespace ManAndBook
{
    public class Student : Man
    {
        private int _admissionYear;
        public int AdmissionYear
        {
            get
            {
                return _admissionYear;
            }
            set
            {
                if ((value >= 1020))
                {
                    _admissionYear = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private string _course;
        public string Course
        {
            get
            {
                return _course;
            }
            set
            {
                if ((value != null))
                {
                    _course = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private int _group;
        public int Group
        {
            get
            {
                return _group;
            }
            set
            {
                if ((value > 0))
                {
                    _group = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        public Student (string newName, int newAge, double newWeigh, double newHight, int newAdmissionYear, string newCourse, int newGroup) : base(newName, newAge, newWeigh, newHight)
        {
            AdmissionYear = newAdmissionYear;
            Course = newCourse;
            Group = newGroup;

        }

        public override string ToString()
        {
            return $"{Name} { Age} { Weight} { Hight} { AdmissionYear} { Course} { Group}";
        }

        public override string GetAge()
        {
            return $"{Age} {AdmissionYear}";
        }

    }
}
