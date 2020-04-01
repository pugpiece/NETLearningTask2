using System;
using System.Collections.Generic;
using System.Text;

namespace ManAndBook
{
    public class Man
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
                if ((value != null) && (value.Length >= 4) && (value.Length <= 30))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if ((value > 0) && (value <= 120))
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        private double _weight;
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if ((value > 0))
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }
        private double _hight;
        public double Hight
        {
            get
            {
                return _hight;
            }
            set
            {
                if ((value > 0))
                {
                    _hight = value;
                }
                else
                {
                    throw new ArgumentException("Wrong data was inputed");
                }
            }
        }

        public Man(string newName, int newAge, double newWeigh, double newHight)
        {
            Name = newName;
            Age = newAge;
            Weight = newWeigh;
            Hight = newHight;
        }

        public override string ToString()
        {
            return $"{Name} { Age} { Weight} { Hight}";
        }

        public virtual string GetAge()
        {
            return $"{Age}";
        }


    }
}
