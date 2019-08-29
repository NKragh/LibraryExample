using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    /// <summary>
    /// A enumerator containing all the genders.
    /// </summary>
    public enum Gender { Male, Female, Other }
    /// <summary>
    /// Student class with name, address and semester.
    /// </summary>
    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;
        private Gender _gender;

        /// <summary>
        /// The Name of the student.
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
        /// The Address of the student.
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
        /// The Semester of the student.
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                CheckSemester(value); _semester = value;
            }
        }
        /// <summary>
        /// The Gender of the student.
        /// </summary>
        public Gender Gender
        {
            get => _gender;
            set
            {
                _gender = value;
            }
        }

        public Student()
        {

        }
        public Student(string name, string address, int semester, Gender gender)
        {
            Name = name;
            Address = address;
            Semester = semester;
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
        /// Check for valid Semester input.
        /// The Semester must be between 1 and 8 including.
        /// </summary>
        /// <param name="inputSemester">The input semester</param>
        /// <returns></returns>
        public bool CheckSemester(int inputSemester)
        {
            if (inputSemester >= 1 && inputSemester <= 8)
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
