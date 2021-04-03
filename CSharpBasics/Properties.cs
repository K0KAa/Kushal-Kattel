using System;

namespace EnumsAndProperties
{
    internal class Person
    {
        public byte age;
        private int grade;

        public string name;
        public string address;
        DateTime dob;


        //Getter Setter
        public byte Age
        {
            get { return age; }
            set
            {
                if (value > 30 && value < 40)
                {
                    age = value;
                }
            }
        }

        public string Address { get; set; }

        public string Name { get; }


    }
}