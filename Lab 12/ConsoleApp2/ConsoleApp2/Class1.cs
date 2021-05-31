using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class TMan
    {
        public string name;
        public int age;
        public string sex
        {
            get { return sex; }
            set
            {
                if (value == "man" || value == "woman")
                {
                    sex = value;
                }
                else
                {
                    throw new Exception("da");
                }
            }
        }

        public TMan(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public string getAgeState()
        {
            if (age > 24) return "adult";
            else if (age > 16) return "teen";
            else return "kid";
        }
    }
}
