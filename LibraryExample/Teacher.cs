using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    /// <summary>
    /// Teacher class with name, address and salary.
    /// </summary>
    public class Teacher
    {
        private string _name;
        private string _address;
        private double _salary;
        private Gender _gender;

        /// <summary>
        /// The Name of the teacher.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                CheckName(value);
                _name = value;
            }
        }
        /// <summary>
        /// The Address of the teacher.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                CheckAddress(value);
                _address = value;
            }
        }
        /// <summary>
        /// The Salary of the teacher.
        /// </summary>
        public double Salary
        {
            get => _salary;
            set
            {
                CheckSalary(value); _salary = value;
            }
        }
        /// <summary>
        /// The Gender of the teacher.
        /// </summary>
        public Gender Gender
        {
            get => _gender;
            set
            {
                _gender = value;
            }
        }

        public Teacher()
        {

        }
        public Teacher(string name, string address, int salary, Gender gender)
        {
            Name = name;
            Address = address;
            Salary = salary;
            Gender = gender;
        }
        /// <summary>
        /// Checks for invalid name input.
        /// The name must be over 2 characters long.
        /// </summary>
        /// <param name="inputName">The input name</param>
        /// <returns></returns>
        public bool CheckName(string inputName)
        {
            if (inputName.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
                //return false;
            }
            return true;
        }
        /// <summary>
        /// Checks for valid Address input.
        /// The address must not be null.
        /// </summary>
        /// <param name="inputAddress">The input address</param>
        /// <returns></returns>
        public bool CheckAddress(string inputAddress)
        {
            if (inputAddress != null)
            {
                return true;
            }
            throw new NullReferenceException();
            //return false;
        }
        /// <summary>
        /// Check for valid Salary input.
        /// The Salary must be between 1 and 8 including.
        /// </summary>
        /// <param name="inputSalary">The input salary</param>
        /// <returns></returns>
        public bool CheckSalary(double inputSalary)
        {
            if (inputSalary >= 0)
            {
                return true;
            }
            throw new ArgumentOutOfRangeException();
            //return false;
        }
        //private Gender ParseGender(string value)
        //{
        //    switch (value)
        //    {
        //        case "Male":
        //            return LibraryExample.Gender.Male;
        //            break;
        //        case "Female":
        //            return LibraryExample.Gender.Female;
        //            break;
        //        default:
        //            return LibraryExample.Gender.Other;
        //            break;
        //    }
        //}
    }
}
