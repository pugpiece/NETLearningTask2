using System;
using System.Collections.Generic;
using System.Text;

namespace ManAndBook
{
    class Author
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != null)
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private int _birthYear;
        public int BirthYear
        {
            get
            {
                return _birthYear;
            }
            set
            {
                if (value >= 0)
                {
                    _birthYear = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        public Author(string newName, string newSurname, int newBirthYear)
        {
            Name = newName;
            Surname = newSurname;
            BirthYear = newBirthYear;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {BirthYear}";
        }
    }
}
