using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters_2
{
    class Student
    {
        public string name;
        public int age;
        public string gender;

        //contructor
        public  Student( string aName, int aAge, string aGender)
        {
            name = aName;
            age = aAge;
            Gender = aGender;
        }

        public string Gender
        {
            get
            {
                return  gender;
            }
            set
            {
                if(value == "male" || value == "female")
                {
                    gender = value;
                }
                else
                {
                    gender = "NOT GENDER";
                }
            }
        }
    }
}
