using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdLesson
{
    class Pupils
    {
        int age;
        string name;
        string lastName;
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Pupils()
        {
            Name = name;
            Age = age;
            LastName = lastName;
        }
        public bool Adult(Pupils a)
        {
            bool adult = false;
            if (a.age >= 18)
                adult = true;
            else
                adult = false;
            return adult;
        }

    }
}
